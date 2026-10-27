using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010E7 RID: 4327
	[NetMessage(EMessageId.RollBlockSwitchControlBlockResponse)]
	public sealed class RollBlockSwitchControlBlockResponse : IMessage<RollBlockSwitchControlBlockResponse>, IMessage, IEquatable<RollBlockSwitchControlBlockResponse>, IDeepCloneable<RollBlockSwitchControlBlockResponse>, IBufferMessage
	{
		// Token: 0x0601713B RID: 94523 RVA: 0x00359381 File Offset: 0x00357581
		[NullableContext(1)]
		public static RollBlockSwitchControlBlockResponse Create()
		{
			return new RollBlockSwitchControlBlockResponse();
		}

		// Token: 0x17004D4A RID: 19786
		// (get) Token: 0x0601713C RID: 94524 RVA: 0x00359388 File Offset: 0x00357588
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D4B RID: 19787
		// (get) Token: 0x0601713D RID: 94525 RVA: 0x0035938B File Offset: 0x0035758B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RollBlockSwitchControlBlockResponse.Descriptor;
			}
		}

		// Token: 0x0601713E RID: 94526 RVA: 0x00359392 File Offset: 0x00357592
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockResponse()
		{
		}

		// Token: 0x0601713F RID: 94527 RVA: 0x0035939A File Offset: 0x0035759A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockResponse(RollBlockSwitchControlBlockResponse other) : this()
		{
			this.code_ = other.code_;
			this.preMainControlBlockEntityId_ = other.preMainControlBlockEntityId_;
			this.curMainControlBlockEntityId_ = other.curMainControlBlockEntityId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06017140 RID: 94528 RVA: 0x003593D7 File Offset: 0x003575D7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RollBlockSwitchControlBlockResponse Clone()
		{
			return new RollBlockSwitchControlBlockResponse(this);
		}

		// Token: 0x17004D4C RID: 19788
		// (get) Token: 0x06017141 RID: 94529 RVA: 0x003593DF File Offset: 0x003575DF
		// (set) Token: 0x06017142 RID: 94530 RVA: 0x003593E7 File Offset: 0x003575E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public ErrorCode Code
		{
			get
			{
				return this.code_;
			}
			set
			{
				this.code_ = value;
			}
		}

		// Token: 0x17004D4D RID: 19789
		// (get) Token: 0x06017143 RID: 94531 RVA: 0x003593F0 File Offset: 0x003575F0
		// (set) Token: 0x06017144 RID: 94532 RVA: 0x003593F8 File Offset: 0x003575F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long PreMainControlBlockEntityId
		{
			get
			{
				return this.preMainControlBlockEntityId_;
			}
			set
			{
				this.preMainControlBlockEntityId_ = value;
			}
		}

		// Token: 0x17004D4E RID: 19790
		// (get) Token: 0x06017145 RID: 94533 RVA: 0x00359401 File Offset: 0x00357601
		// (set) Token: 0x06017146 RID: 94534 RVA: 0x00359409 File Offset: 0x00357609
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurMainControlBlockEntityId
		{
			get
			{
				return this.curMainControlBlockEntityId_;
			}
			set
			{
				this.curMainControlBlockEntityId_ = value;
			}
		}

		// Token: 0x06017147 RID: 94535 RVA: 0x00359412 File Offset: 0x00357612
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RollBlockSwitchControlBlockResponse);
		}

		// Token: 0x06017148 RID: 94536 RVA: 0x00359420 File Offset: 0x00357620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RollBlockSwitchControlBlockResponse other)
		{
			return other != null && (other == this || (this.Code == other.Code && this.PreMainControlBlockEntityId == other.PreMainControlBlockEntityId && this.CurMainControlBlockEntityId == other.CurMainControlBlockEntityId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017149 RID: 94537 RVA: 0x0035947C File Offset: 0x0035767C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Code != ErrorCode.Success)
			{
				num ^= this.Code.GetHashCode();
			}
			if (this.PreMainControlBlockEntityId != 0L)
			{
				num ^= this.PreMainControlBlockEntityId.GetHashCode();
			}
			if (this.CurMainControlBlockEntityId != 0L)
			{
				num ^= this.CurMainControlBlockEntityId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601714A RID: 94538 RVA: 0x003594F3 File Offset: 0x003576F3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601714B RID: 94539 RVA: 0x00359500 File Offset: 0x00357700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601714C RID: 94540 RVA: 0x0035950C File Offset: 0x0035770C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.CurMainControlBlockEntityId != 0L)
			{
				output.WriteRawTag(40);
				output.WriteInt64(this.CurMainControlBlockEntityId);
			}
			if (this.Code != ErrorCode.Success)
			{
				output.WriteRawTag(80);
				output.WriteEnum((int)this.Code);
			}
			if (this.PreMainControlBlockEntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.PreMainControlBlockEntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601714D RID: 94541 RVA: 0x00359584 File Offset: 0x00357784
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Code != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Code);
			}
			if (this.PreMainControlBlockEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.PreMainControlBlockEntityId);
			}
			if (this.CurMainControlBlockEntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurMainControlBlockEntityId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601714E RID: 94542 RVA: 0x003595F4 File Offset: 0x003577F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RollBlockSwitchControlBlockResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Code != ErrorCode.Success)
			{
				this.Code = other.Code;
			}
			if (other.PreMainControlBlockEntityId != 0L)
			{
				this.PreMainControlBlockEntityId = other.PreMainControlBlockEntityId;
			}
			if (other.CurMainControlBlockEntityId != 0L)
			{
				this.CurMainControlBlockEntityId = other.CurMainControlBlockEntityId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601714F RID: 94543 RVA: 0x00359658 File Offset: 0x00357858
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017150 RID: 94544 RVA: 0x00359664 File Offset: 0x00357864
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
				if (num != 40U)
				{
					if (num != 80U)
					{
						if (num != 104U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.PreMainControlBlockEntityId = input.ReadInt64();
						}
					}
					else
					{
						this.Code = (ErrorCode)input.ReadEnum();
					}
				}
				else
				{
					this.CurMainControlBlockEntityId = input.ReadInt64();
				}
			}
		}

		// Token: 0x04008943 RID: 35139
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008944 RID: 35140
		public const int CodeFieldNumber = 10;

		// Token: 0x04008945 RID: 35141
		private ErrorCode code_;

		// Token: 0x04008946 RID: 35142
		public const int PreMainControlBlockEntityIdFieldNumber = 13;

		// Token: 0x04008947 RID: 35143
		private long preMainControlBlockEntityId_;

		// Token: 0x04008948 RID: 35144
		public const int CurMainControlBlockEntityIdFieldNumber = 5;

		// Token: 0x04008949 RID: 35145
		private long curMainControlBlockEntityId_;
	}
}
