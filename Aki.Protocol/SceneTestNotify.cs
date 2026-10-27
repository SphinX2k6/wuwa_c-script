using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001193 RID: 4499
	[NetMessage(EMessageId.SceneTestNotify)]
	public sealed class SceneTestNotify : IMessage<SceneTestNotify>, IMessage, IEquatable<SceneTestNotify>, IDeepCloneable<SceneTestNotify>, IBufferMessage
	{
		// Token: 0x06017FA4 RID: 98212 RVA: 0x0037B776 File Offset: 0x00379976
		[NullableContext(1)]
		public static SceneTestNotify Create()
		{
			return new SceneTestNotify();
		}

		// Token: 0x17005093 RID: 20627
		// (get) Token: 0x06017FA5 RID: 98213 RVA: 0x0037B77D File Offset: 0x0037997D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005094 RID: 20628
		// (get) Token: 0x06017FA6 RID: 98214 RVA: 0x0037B780 File Offset: 0x00379980
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SceneTestNotify.Descriptor;
			}
		}

		// Token: 0x06017FA7 RID: 98215 RVA: 0x0037B787 File Offset: 0x00379987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTestNotify()
		{
		}

		// Token: 0x06017FA8 RID: 98216 RVA: 0x0037B79A File Offset: 0x0037999A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTestNotify(SceneTestNotify other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.errorMsg_ = other.errorMsg_;
			this.playerId_ = other.playerId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017FA9 RID: 98217 RVA: 0x0037B7D7 File Offset: 0x003799D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SceneTestNotify Clone()
		{
			return new SceneTestNotify(this);
		}

		// Token: 0x17005095 RID: 20629
		// (get) Token: 0x06017FAA RID: 98218 RVA: 0x0037B7DF File Offset: 0x003799DF
		// (set) Token: 0x06017FAB RID: 98219 RVA: 0x0037B7E7 File Offset: 0x003799E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode ErrorCode
		{
			get
			{
				return this.errorCode_;
			}
			set
			{
				this.errorCode_ = value;
			}
		}

		// Token: 0x17005096 RID: 20630
		// (get) Token: 0x06017FAC RID: 98220 RVA: 0x0037B7F0 File Offset: 0x003799F0
		// (set) Token: 0x06017FAD RID: 98221 RVA: 0x0037B7F8 File Offset: 0x003799F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public string ErrorMsg
		{
			get
			{
				return this.errorMsg_;
			}
			set
			{
				this.errorMsg_ = ProtoPreconditions.CheckNotNull<string>(value, "value");
			}
		}

		// Token: 0x17005097 RID: 20631
		// (get) Token: 0x06017FAE RID: 98222 RVA: 0x0037B80B File Offset: 0x00379A0B
		// (set) Token: 0x06017FAF RID: 98223 RVA: 0x0037B813 File Offset: 0x00379A13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PlayerId
		{
			get
			{
				return this.playerId_;
			}
			set
			{
				this.playerId_ = value;
			}
		}

		// Token: 0x06017FB0 RID: 98224 RVA: 0x0037B81C File Offset: 0x00379A1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SceneTestNotify);
		}

		// Token: 0x06017FB1 RID: 98225 RVA: 0x0037B82C File Offset: 0x00379A2C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SceneTestNotify other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && !(this.ErrorMsg != other.ErrorMsg) && this.PlayerId == other.PlayerId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017FB2 RID: 98226 RVA: 0x0037B88C File Offset: 0x00379A8C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			if (this.ErrorMsg.Length != 0)
			{
				num ^= this.ErrorMsg.GetHashCode();
			}
			if (this.PlayerId != 0)
			{
				num ^= this.PlayerId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017FB3 RID: 98227 RVA: 0x0037B905 File Offset: 0x00379B05
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017FB4 RID: 98228 RVA: 0x0037B912 File Offset: 0x00379B12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017FB5 RID: 98229 RVA: 0x0037B91C File Offset: 0x00379B1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.PlayerId != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.PlayerId);
			}
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(112);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.ErrorMsg.Length != 0)
			{
				output.WriteRawTag(122);
				output.WriteString(this.ErrorMsg);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017FB6 RID: 98230 RVA: 0x0037B998 File Offset: 0x00379B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			if (this.ErrorMsg.Length != 0)
			{
				num += 1 + CodedOutputStream.ComputeStringSize(this.ErrorMsg);
			}
			if (this.PlayerId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PlayerId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017FB7 RID: 98231 RVA: 0x0037BA0C File Offset: 0x00379C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SceneTestNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			if (other.ErrorMsg.Length != 0)
			{
				this.ErrorMsg = other.ErrorMsg;
			}
			if (other.PlayerId != 0)
			{
				this.PlayerId = other.PlayerId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017FB8 RID: 98232 RVA: 0x0037BA75 File Offset: 0x00379C75
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017FB9 RID: 98233 RVA: 0x0037BA80 File Offset: 0x00379C80
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
				if (num != 24U)
				{
					if (num != 112U)
					{
						if (num != 122U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.ErrorMsg = input.ReadString();
						}
					}
					else
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.PlayerId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04008E09 RID: 36361
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008E0A RID: 36362
		public const int ErrorCodeFieldNumber = 14;

		// Token: 0x04008E0B RID: 36363
		private ErrorCode errorCode_;

		// Token: 0x04008E0C RID: 36364
		public const int ErrorMsgFieldNumber = 15;

		// Token: 0x04008E0D RID: 36365
		private string errorMsg_ = "";

		// Token: 0x04008E0E RID: 36366
		public const int PlayerIdFieldNumber = 3;

		// Token: 0x04008E0F RID: 36367
		private int playerId_;
	}
}
