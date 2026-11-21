using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005B4 RID: 1460
	[NetMessage(EMessageId.FloroRanchPlayRemoveUnitResponse)]
	public sealed class FloroRanchPlayRemoveUnitResponse : IMessage<FloroRanchPlayRemoveUnitResponse>, IMessage, IEquatable<FloroRanchPlayRemoveUnitResponse>, IDeepCloneable<FloroRanchPlayRemoveUnitResponse>, IBufferMessage
	{
		// Token: 0x06008770 RID: 34672 RVA: 0x00146F5F File Offset: 0x0014515F
		[NullableContext(1)]
		public static FloroRanchPlayRemoveUnitResponse Create()
		{
			return new FloroRanchPlayRemoveUnitResponse();
		}

		// Token: 0x17001A8B RID: 6795
		// (get) Token: 0x06008771 RID: 34673 RVA: 0x00146F66 File Offset: 0x00145166
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001A8C RID: 6796
		// (get) Token: 0x06008772 RID: 34674 RVA: 0x00146F69 File Offset: 0x00145169
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRemoveUnitResponse.Descriptor;
			}
		}

		// Token: 0x06008773 RID: 34675 RVA: 0x00146F70 File Offset: 0x00145170
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitResponse()
		{
		}

		// Token: 0x06008774 RID: 34676 RVA: 0x00146F84 File Offset: 0x00145184
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitResponse(FloroRanchPlayRemoveUnitResponse other) : this()
		{
			this.errorCode_ = other.errorCode_;
			this.task_ = other.task_.Clone();
			this.curCoin_ = other.curCoin_;
			this.curDiamond_ = other.curDiamond_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06008775 RID: 34677 RVA: 0x00146FDD File Offset: 0x001451DD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitResponse Clone()
		{
			return new FloroRanchPlayRemoveUnitResponse(this);
		}

		// Token: 0x17001A8D RID: 6797
		// (get) Token: 0x06008776 RID: 34678 RVA: 0x00146FE5 File Offset: 0x001451E5
		// (set) Token: 0x06008777 RID: 34679 RVA: 0x00146FED File Offset: 0x001451ED
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

		// Token: 0x17001A8E RID: 6798
		// (get) Token: 0x06008778 RID: 34680 RVA: 0x00146FF6 File Offset: 0x001451F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x17001A8F RID: 6799
		// (get) Token: 0x06008779 RID: 34681 RVA: 0x00146FFE File Offset: 0x001451FE
		// (set) Token: 0x0600877A RID: 34682 RVA: 0x00147006 File Offset: 0x00145206
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurCoin
		{
			get
			{
				return this.curCoin_;
			}
			set
			{
				this.curCoin_ = value;
			}
		}

		// Token: 0x17001A90 RID: 6800
		// (get) Token: 0x0600877B RID: 34683 RVA: 0x0014700F File Offset: 0x0014520F
		// (set) Token: 0x0600877C RID: 34684 RVA: 0x00147017 File Offset: 0x00145217
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long CurDiamond
		{
			get
			{
				return this.curDiamond_;
			}
			set
			{
				this.curDiamond_ = value;
			}
		}

		// Token: 0x0600877D RID: 34685 RVA: 0x00147020 File Offset: 0x00145220
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRemoveUnitResponse);
		}

		// Token: 0x0600877E RID: 34686 RVA: 0x00147030 File Offset: 0x00145230
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRemoveUnitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.task_.Equals(other.task_) && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600877F RID: 34687 RVA: 0x001470A0 File Offset: 0x001452A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num ^= this.ErrorCode.GetHashCode();
			}
			num ^= this.task_.GetHashCode();
			if (this.CurCoin != 0L)
			{
				num ^= this.CurCoin.GetHashCode();
			}
			if (this.CurDiamond != 0L)
			{
				num ^= this.CurDiamond.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06008780 RID: 34688 RVA: 0x00147125 File Offset: 0x00145325
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06008781 RID: 34689 RVA: 0x00147132 File Offset: 0x00145332
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06008782 RID: 34690 RVA: 0x0014713C File Offset: 0x0014533C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.task_.WriteTo(ref output, FloroRanchPlayRemoveUnitResponse._repeated_task_codec);
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(56);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.CurDiamond);
			}
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.CurCoin);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06008783 RID: 34691 RVA: 0x001471C4 File Offset: 0x001453C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ErrorCode != ErrorCode.Success)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.ErrorCode);
			}
			num += this.task_.CalculateSize(FloroRanchPlayRemoveUnitResponse._repeated_task_codec);
			if (this.CurCoin != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurCoin);
			}
			if (this.CurDiamond != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.CurDiamond);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06008784 RID: 34692 RVA: 0x00147248 File Offset: 0x00145448
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FloroRanchPlayRemoveUnitResponse other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ErrorCode != ErrorCode.Success)
			{
				this.ErrorCode = other.ErrorCode;
			}
			this.task_.Add(other.task_);
			if (other.CurCoin != 0L)
			{
				this.CurCoin = other.CurCoin;
			}
			if (other.CurDiamond != 0L)
			{
				this.CurDiamond = other.CurDiamond;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06008785 RID: 34693 RVA: 0x001472BD File Offset: 0x001454BD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06008786 RID: 34694 RVA: 0x001472C8 File Offset: 0x001454C8
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
				if (num <= 56U)
				{
					if (num == 18U)
					{
						this.task_.AddEntriesFrom(ref input, FloroRanchPlayRemoveUnitResponse._repeated_task_codec);
						continue;
					}
					if (num == 56U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 80U)
					{
						this.CurDiamond = input.ReadInt64();
						continue;
					}
					if (num == 120U)
					{
						this.CurCoin = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004346 RID: 17222
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004347 RID: 17223
		public const int ErrorCodeFieldNumber = 7;

		// Token: 0x04004348 RID: 17224
		private ErrorCode errorCode_;

		// Token: 0x04004349 RID: 17225
		public const int TaskFieldNumber = 2;

		// Token: 0x0400434A RID: 17226
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(18U, FloroRanchPlayTask.Parser);

		// Token: 0x0400434B RID: 17227
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();

		// Token: 0x0400434C RID: 17228
		public const int CurCoinFieldNumber = 15;

		// Token: 0x0400434D RID: 17229
		private long curCoin_;

		// Token: 0x0400434E RID: 17230
		public const int CurDiamondFieldNumber = 10;

		// Token: 0x0400434F RID: 17231
		private long curDiamond_;
	}
}
