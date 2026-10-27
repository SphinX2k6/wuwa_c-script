using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001352 RID: 4946
	public sealed class TetrisActivityInfo : IMessage<TetrisActivityInfo>, IMessage, IEquatable<TetrisActivityInfo>, IDeepCloneable<TetrisActivityInfo>, IBufferMessage
	{
		// Token: 0x0601A474 RID: 107636 RVA: 0x003D16F7 File Offset: 0x003CF8F7
		[NullableContext(1)]
		public static TetrisActivityInfo Create()
		{
			return new TetrisActivityInfo();
		}

		// Token: 0x170058AA RID: 22698
		// (get) Token: 0x0601A475 RID: 107637 RVA: 0x003D16FE File Offset: 0x003CF8FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170058AB RID: 22699
		// (get) Token: 0x0601A476 RID: 107638 RVA: 0x003D1701 File Offset: 0x003CF901
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TetrisActivityInfo.Descriptor;
			}
		}

		// Token: 0x0601A477 RID: 107639 RVA: 0x003D1708 File Offset: 0x003CF908
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisActivityInfo()
		{
		}

		// Token: 0x0601A478 RID: 107640 RVA: 0x003D171B File Offset: 0x003CF91B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisActivityInfo(TetrisActivityInfo other) : this()
		{
			this.tetrisLevelInfos_ = other.tetrisLevelInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A479 RID: 107641 RVA: 0x003D1745 File Offset: 0x003CF945
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TetrisActivityInfo Clone()
		{
			return new TetrisActivityInfo(this);
		}

		// Token: 0x170058AC RID: 22700
		// (get) Token: 0x0601A47A RID: 107642 RVA: 0x003D174D File Offset: 0x003CF94D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TetrisLevelInfo> TetrisLevelInfos
		{
			get
			{
				return this.tetrisLevelInfos_;
			}
		}

		// Token: 0x0601A47B RID: 107643 RVA: 0x003D1755 File Offset: 0x003CF955
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TetrisActivityInfo);
		}

		// Token: 0x0601A47C RID: 107644 RVA: 0x003D1763 File Offset: 0x003CF963
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TetrisActivityInfo other)
		{
			return other != null && (other == this || (this.tetrisLevelInfos_.Equals(other.tetrisLevelInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A47D RID: 107645 RVA: 0x003D1798 File Offset: 0x003CF998
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.tetrisLevelInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A47E RID: 107646 RVA: 0x003D17CC File Offset: 0x003CF9CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A47F RID: 107647 RVA: 0x003D17D9 File Offset: 0x003CF9D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A480 RID: 107648 RVA: 0x003D17E2 File Offset: 0x003CF9E2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.tetrisLevelInfos_.WriteTo(ref output, TetrisActivityInfo._repeated_tetrisLevelInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A481 RID: 107649 RVA: 0x003D180C File Offset: 0x003CFA0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.tetrisLevelInfos_.CalculateSize(TetrisActivityInfo._repeated_tetrisLevelInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A482 RID: 107650 RVA: 0x003D1845 File Offset: 0x003CFA45
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TetrisActivityInfo other)
		{
			if (other == null)
			{
				return;
			}
			this.tetrisLevelInfos_.Add(other.tetrisLevelInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A483 RID: 107651 RVA: 0x003D1873 File Offset: 0x003CFA73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A484 RID: 107652 RVA: 0x003D187C File Offset: 0x003CFA7C
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.tetrisLevelInfos_.AddEntriesFrom(ref input, TetrisActivityInfo._repeated_tetrisLevelInfos_codec);
				}
			}
		}

		// Token: 0x04009943 RID: 39235
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009944 RID: 39236
		public const int TetrisLevelInfosFieldNumber = 1;

		// Token: 0x04009945 RID: 39237
		private static readonly FieldCodec<TetrisLevelInfo> _repeated_tetrisLevelInfos_codec = FieldCodec.ForMessage<TetrisLevelInfo>(10U, TetrisLevelInfo.Parser);

		// Token: 0x04009946 RID: 39238
		private readonly RepeatedField<TetrisLevelInfo> tetrisLevelInfos_ = new RepeatedField<TetrisLevelInfo>();
	}
}
