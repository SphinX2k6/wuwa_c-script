using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012FD RID: 4861
	[NetMessage(EMessageId.StartRecallRequest)]
	public sealed class StartRecallRequest : IMessage<StartRecallRequest>, IMessage, IEquatable<StartRecallRequest>, IDeepCloneable<StartRecallRequest>, IBufferMessage
	{
		// Token: 0x06019EE2 RID: 106210 RVA: 0x003C8001 File Offset: 0x003C6201
		[NullableContext(1)]
		public static StartRecallRequest Create()
		{
			return new StartRecallRequest();
		}

		// Token: 0x170057D1 RID: 22481
		// (get) Token: 0x06019EE3 RID: 106211 RVA: 0x003C8008 File Offset: 0x003C6208
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170057D2 RID: 22482
		// (get) Token: 0x06019EE4 RID: 106212 RVA: 0x003C800B File Offset: 0x003C620B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return StartRecallRequest.Descriptor;
			}
		}

		// Token: 0x06019EE5 RID: 106213 RVA: 0x003C8012 File Offset: 0x003C6212
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallRequest()
		{
		}

		// Token: 0x06019EE6 RID: 106214 RVA: 0x003C801A File Offset: 0x003C621A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallRequest(StartRecallRequest other) : this()
		{
			this.recallId_ = other.recallId_;
			this.continue_ = other.continue_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019EE7 RID: 106215 RVA: 0x003C804B File Offset: 0x003C624B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public StartRecallRequest Clone()
		{
			return new StartRecallRequest(this);
		}

		// Token: 0x170057D3 RID: 22483
		// (get) Token: 0x06019EE8 RID: 106216 RVA: 0x003C8053 File Offset: 0x003C6253
		// (set) Token: 0x06019EE9 RID: 106217 RVA: 0x003C805B File Offset: 0x003C625B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RecallId
		{
			get
			{
				return this.recallId_;
			}
			set
			{
				this.recallId_ = value;
			}
		}

		// Token: 0x170057D4 RID: 22484
		// (get) Token: 0x06019EEA RID: 106218 RVA: 0x003C8064 File Offset: 0x003C6264
		// (set) Token: 0x06019EEB RID: 106219 RVA: 0x003C806C File Offset: 0x003C626C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Continue
		{
			get
			{
				return this.continue_;
			}
			set
			{
				this.continue_ = value;
			}
		}

		// Token: 0x06019EEC RID: 106220 RVA: 0x003C8075 File Offset: 0x003C6275
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as StartRecallRequest);
		}

		// Token: 0x06019EED RID: 106221 RVA: 0x003C8083 File Offset: 0x003C6283
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(StartRecallRequest other)
		{
			return other != null && (other == this || (this.RecallId == other.RecallId && this.Continue == other.Continue && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019EEE RID: 106222 RVA: 0x003C80C4 File Offset: 0x003C62C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.RecallId != 0)
			{
				num ^= this.RecallId.GetHashCode();
			}
			if (this.Continue)
			{
				num ^= this.Continue.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019EEF RID: 106223 RVA: 0x003C811C File Offset: 0x003C631C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019EF0 RID: 106224 RVA: 0x003C8129 File Offset: 0x003C6329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019EF1 RID: 106225 RVA: 0x003C8134 File Offset: 0x003C6334
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RecallId != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.RecallId);
			}
			if (this.Continue)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.Continue);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019EF2 RID: 106226 RVA: 0x003C8190 File Offset: 0x003C6390
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.RecallId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RecallId);
			}
			if (this.Continue)
			{
				num += 2;
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019EF3 RID: 106227 RVA: 0x003C81DC File Offset: 0x003C63DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(StartRecallRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.RecallId != 0)
			{
				this.RecallId = other.RecallId;
			}
			if (other.Continue)
			{
				this.Continue = other.Continue;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06019EF4 RID: 106228 RVA: 0x003C822C File Offset: 0x003C642C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019EF5 RID: 106229 RVA: 0x003C8238 File Offset: 0x003C6438
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
				if (num != 16U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Continue = input.ReadBool();
					}
				}
				else
				{
					this.RecallId = input.ReadInt32();
				}
			}
		}

		// Token: 0x040098DD RID: 39133
		private UnknownFieldSet _unknownFields;

		// Token: 0x040098DE RID: 39134
		public const int RecallIdFieldNumber = 2;

		// Token: 0x040098DF RID: 39135
		private int recallId_;

		// Token: 0x040098E0 RID: 39136
		public const int ContinueFieldNumber = 7;

		// Token: 0x040098E1 RID: 39137
		private bool continue_;
	}
}
