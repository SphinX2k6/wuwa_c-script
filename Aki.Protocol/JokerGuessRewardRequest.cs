using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000872 RID: 2162
	[NetMessage(EMessageId.JokerGuessRewardRequest)]
	public sealed class JokerGuessRewardRequest : IMessage<JokerGuessRewardRequest>, IMessage, IEquatable<JokerGuessRewardRequest>, IDeepCloneable<JokerGuessRewardRequest>, IBufferMessage
	{
		// Token: 0x0600C093 RID: 49299 RVA: 0x001C98C4 File Offset: 0x001C7AC4
		[NullableContext(1)]
		public static JokerGuessRewardRequest Create()
		{
			return new JokerGuessRewardRequest();
		}

		// Token: 0x170026EA RID: 9962
		// (get) Token: 0x0600C094 RID: 49300 RVA: 0x001C98CB File Offset: 0x001C7ACB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026EB RID: 9963
		// (get) Token: 0x0600C095 RID: 49301 RVA: 0x001C98CE File Offset: 0x001C7ACE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600C096 RID: 49302 RVA: 0x001C98D5 File Offset: 0x001C7AD5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardRequest()
		{
		}

		// Token: 0x0600C097 RID: 49303 RVA: 0x001C98DD File Offset: 0x001C7ADD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardRequest(JokerGuessRewardRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600C098 RID: 49304 RVA: 0x001C9902 File Offset: 0x001C7B02
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardRequest Clone()
		{
			return new JokerGuessRewardRequest(this);
		}

		// Token: 0x170026EC RID: 9964
		// (get) Token: 0x0600C099 RID: 49305 RVA: 0x001C990A File Offset: 0x001C7B0A
		// (set) Token: 0x0600C09A RID: 49306 RVA: 0x001C9912 File Offset: 0x001C7B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int LevelId
		{
			get
			{
				return this.levelId_;
			}
			set
			{
				this.levelId_ = value;
			}
		}

		// Token: 0x0600C09B RID: 49307 RVA: 0x001C991B File Offset: 0x001C7B1B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessRewardRequest);
		}

		// Token: 0x0600C09C RID: 49308 RVA: 0x001C9929 File Offset: 0x001C7B29
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessRewardRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600C09D RID: 49309 RVA: 0x001C9958 File Offset: 0x001C7B58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.LevelId != 0)
			{
				num ^= this.LevelId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600C09E RID: 49310 RVA: 0x001C9997 File Offset: 0x001C7B97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600C09F RID: 49311 RVA: 0x001C99A4 File Offset: 0x001C7BA4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600C0A0 RID: 49312 RVA: 0x001C99AD File Offset: 0x001C7BAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(104);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600C0A1 RID: 49313 RVA: 0x001C99E0 File Offset: 0x001C7BE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.LevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600C0A2 RID: 49314 RVA: 0x001C9A1E File Offset: 0x001C7C1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(JokerGuessRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.LevelId != 0)
			{
				this.LevelId = other.LevelId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600C0A3 RID: 49315 RVA: 0x001C9A4F File Offset: 0x001C7C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600C0A4 RID: 49316 RVA: 0x001C9A58 File Offset: 0x001C7C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 104U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040053A7 RID: 21415
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053A8 RID: 21416
		public const int LevelIdFieldNumber = 13;

		// Token: 0x040053A9 RID: 21417
		private int levelId_;
	}
}
