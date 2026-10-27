using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020005C9 RID: 1481
	[NetMessage(EMessageId.FloroRanchPlayRemoveUnitResponse)]
	public sealed class FloroRanchPlayRemoveUnitResponse : IMessage<FloroRanchPlayRemoveUnitResponse>, IMessage, IEquatable<FloroRanchPlayRemoveUnitResponse>, IDeepCloneable<FloroRanchPlayRemoveUnitResponse>, IBufferMessage
	{
		// Token: 0x060088D8 RID: 35032 RVA: 0x00149B77 File Offset: 0x00147D77
		[NullableContext(1)]
		public static FloroRanchPlayRemoveUnitResponse Create()
		{
			return new FloroRanchPlayRemoveUnitResponse();
		}

		// Token: 0x17001AD8 RID: 6872
		// (get) Token: 0x060088D9 RID: 35033 RVA: 0x00149B7E File Offset: 0x00147D7E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001AD9 RID: 6873
		// (get) Token: 0x060088DA RID: 35034 RVA: 0x00149B81 File Offset: 0x00147D81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FloroRanchPlayRemoveUnitResponse.Descriptor;
			}
		}

		// Token: 0x060088DB RID: 35035 RVA: 0x00149B88 File Offset: 0x00147D88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitResponse()
		{
		}

		// Token: 0x060088DC RID: 35036 RVA: 0x00149B9C File Offset: 0x00147D9C
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

		// Token: 0x060088DD RID: 35037 RVA: 0x00149BF5 File Offset: 0x00147DF5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FloroRanchPlayRemoveUnitResponse Clone()
		{
			return new FloroRanchPlayRemoveUnitResponse(this);
		}

		// Token: 0x17001ADA RID: 6874
		// (get) Token: 0x060088DE RID: 35038 RVA: 0x00149BFD File Offset: 0x00147DFD
		// (set) Token: 0x060088DF RID: 35039 RVA: 0x00149C05 File Offset: 0x00147E05
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

		// Token: 0x17001ADB RID: 6875
		// (get) Token: 0x060088E0 RID: 35040 RVA: 0x00149C0E File Offset: 0x00147E0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchPlayTask> Task
		{
			get
			{
				return this.task_;
			}
		}

		// Token: 0x17001ADC RID: 6876
		// (get) Token: 0x060088E1 RID: 35041 RVA: 0x00149C16 File Offset: 0x00147E16
		// (set) Token: 0x060088E2 RID: 35042 RVA: 0x00149C1E File Offset: 0x00147E1E
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

		// Token: 0x17001ADD RID: 6877
		// (get) Token: 0x060088E3 RID: 35043 RVA: 0x00149C27 File Offset: 0x00147E27
		// (set) Token: 0x060088E4 RID: 35044 RVA: 0x00149C2F File Offset: 0x00147E2F
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

		// Token: 0x060088E5 RID: 35045 RVA: 0x00149C38 File Offset: 0x00147E38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FloroRanchPlayRemoveUnitResponse);
		}

		// Token: 0x060088E6 RID: 35046 RVA: 0x00149C48 File Offset: 0x00147E48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FloroRanchPlayRemoveUnitResponse other)
		{
			return other != null && (other == this || (this.ErrorCode == other.ErrorCode && this.task_.Equals(other.task_) && this.CurCoin == other.CurCoin && this.CurDiamond == other.CurDiamond && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060088E7 RID: 35047 RVA: 0x00149CB8 File Offset: 0x00147EB8
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

		// Token: 0x060088E8 RID: 35048 RVA: 0x00149D3D File Offset: 0x00147F3D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060088E9 RID: 35049 RVA: 0x00149D4A File Offset: 0x00147F4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060088EA RID: 35050 RVA: 0x00149D54 File Offset: 0x00147F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ErrorCode != ErrorCode.Success)
			{
				output.WriteRawTag(40);
				output.WriteEnum((int)this.ErrorCode);
			}
			if (this.CurCoin != 0L)
			{
				output.WriteRawTag(64);
				output.WriteInt64(this.CurCoin);
			}
			this.task_.WriteTo(ref output, FloroRanchPlayRemoveUnitResponse._repeated_task_codec);
			if (this.CurDiamond != 0L)
			{
				output.WriteRawTag(80);
				output.WriteInt64(this.CurDiamond);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060088EB RID: 35051 RVA: 0x00149DDC File Offset: 0x00147FDC
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

		// Token: 0x060088EC RID: 35052 RVA: 0x00149E60 File Offset: 0x00148060
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

		// Token: 0x060088ED RID: 35053 RVA: 0x00149ED5 File Offset: 0x001480D5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060088EE RID: 35054 RVA: 0x00149EE0 File Offset: 0x001480E0
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
				if (num <= 64U)
				{
					if (num == 40U)
					{
						this.ErrorCode = (ErrorCode)input.ReadEnum();
						continue;
					}
					if (num == 64U)
					{
						this.CurCoin = input.ReadInt64();
						continue;
					}
				}
				else
				{
					if (num == 74U)
					{
						this.task_.AddEntriesFrom(ref input, FloroRanchPlayRemoveUnitResponse._repeated_task_codec);
						continue;
					}
					if (num == 80U)
					{
						this.CurDiamond = input.ReadInt64();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04004350 RID: 17232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004351 RID: 17233
		public const int ErrorCodeFieldNumber = 5;

		// Token: 0x04004352 RID: 17234
		private ErrorCode errorCode_;

		// Token: 0x04004353 RID: 17235
		public const int TaskFieldNumber = 9;

		// Token: 0x04004354 RID: 17236
		private static readonly FieldCodec<FloroRanchPlayTask> _repeated_task_codec = FieldCodec.ForMessage<FloroRanchPlayTask>(74U, FloroRanchPlayTask.Parser);

		// Token: 0x04004355 RID: 17237
		private readonly RepeatedField<FloroRanchPlayTask> task_ = new RepeatedField<FloroRanchPlayTask>();

		// Token: 0x04004356 RID: 17238
		public const int CurCoinFieldNumber = 8;

		// Token: 0x04004357 RID: 17239
		private long curCoin_;

		// Token: 0x04004358 RID: 17240
		public const int CurDiamondFieldNumber = 10;

		// Token: 0x04004359 RID: 17241
		private long curDiamond_;
	}
}
