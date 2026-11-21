using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000861 RID: 2145
	[NetMessage(EMessageId.JokerGuessRewardRequest)]
	public sealed class JokerGuessRewardRequest : IMessage<JokerGuessRewardRequest>, IMessage, IEquatable<JokerGuessRewardRequest>, IDeepCloneable<JokerGuessRewardRequest>, IBufferMessage
	{
		// Token: 0x0600BF77 RID: 49015 RVA: 0x001C75DC File Offset: 0x001C57DC
		[NullableContext(1)]
		public static JokerGuessRewardRequest Create()
		{
			return new JokerGuessRewardRequest();
		}

		// Token: 0x170026AB RID: 9899
		// (get) Token: 0x0600BF78 RID: 49016 RVA: 0x001C75E3 File Offset: 0x001C57E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170026AC RID: 9900
		// (get) Token: 0x0600BF79 RID: 49017 RVA: 0x001C75E6 File Offset: 0x001C57E6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return JokerGuessRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600BF7A RID: 49018 RVA: 0x001C75ED File Offset: 0x001C57ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardRequest()
		{
		}

		// Token: 0x0600BF7B RID: 49019 RVA: 0x001C75F5 File Offset: 0x001C57F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardRequest(JokerGuessRewardRequest other) : this()
		{
			this.levelId_ = other.levelId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600BF7C RID: 49020 RVA: 0x001C761A File Offset: 0x001C581A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public JokerGuessRewardRequest Clone()
		{
			return new JokerGuessRewardRequest(this);
		}

		// Token: 0x170026AD RID: 9901
		// (get) Token: 0x0600BF7D RID: 49021 RVA: 0x001C7622 File Offset: 0x001C5822
		// (set) Token: 0x0600BF7E RID: 49022 RVA: 0x001C762A File Offset: 0x001C582A
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

		// Token: 0x0600BF7F RID: 49023 RVA: 0x001C7633 File Offset: 0x001C5833
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as JokerGuessRewardRequest);
		}

		// Token: 0x0600BF80 RID: 49024 RVA: 0x001C7641 File Offset: 0x001C5841
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(JokerGuessRewardRequest other)
		{
			return other != null && (other == this || (this.LevelId == other.LevelId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600BF81 RID: 49025 RVA: 0x001C7670 File Offset: 0x001C5870
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

		// Token: 0x0600BF82 RID: 49026 RVA: 0x001C76AF File Offset: 0x001C58AF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600BF83 RID: 49027 RVA: 0x001C76BC File Offset: 0x001C58BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600BF84 RID: 49028 RVA: 0x001C76C5 File Offset: 0x001C58C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.LevelId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.LevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600BF85 RID: 49029 RVA: 0x001C76F8 File Offset: 0x001C58F8
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

		// Token: 0x0600BF86 RID: 49030 RVA: 0x001C7736 File Offset: 0x001C5936
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

		// Token: 0x0600BF87 RID: 49031 RVA: 0x001C7767 File Offset: 0x001C5967
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600BF88 RID: 49032 RVA: 0x001C7770 File Offset: 0x001C5970
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
				if (num != 48U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.LevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040053AE RID: 21422
		private UnknownFieldSet _unknownFields;

		// Token: 0x040053AF RID: 21423
		public const int LevelIdFieldNumber = 6;

		// Token: 0x040053B0 RID: 21424
		private int levelId_;
	}
}
