using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E81 RID: 3713
	public sealed class RacingBetsUpdateRank : IMessage<RacingBetsUpdateRank>, IMessage, IEquatable<RacingBetsUpdateRank>, IDeepCloneable<RacingBetsUpdateRank>, IBufferMessage
	{
		// Token: 0x06013F0F RID: 81679 RVA: 0x002E73D9 File Offset: 0x002E55D9
		[NullableContext(1)]
		public static RacingBetsUpdateRank Create()
		{
			return new RacingBetsUpdateRank();
		}

		// Token: 0x17004251 RID: 16977
		// (get) Token: 0x06013F10 RID: 81680 RVA: 0x002E73E0 File Offset: 0x002E55E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004252 RID: 16978
		// (get) Token: 0x06013F11 RID: 81681 RVA: 0x002E73E3 File Offset: 0x002E55E3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsUpdateRank.Descriptor;
			}
		}

		// Token: 0x06013F12 RID: 81682 RVA: 0x002E73EA File Offset: 0x002E55EA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateRank()
		{
		}

		// Token: 0x06013F13 RID: 81683 RVA: 0x002E73FD File Offset: 0x002E55FD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateRank(RacingBetsUpdateRank other) : this()
		{
			this.dangoId_ = other.dangoId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013F14 RID: 81684 RVA: 0x002E7427 File Offset: 0x002E5627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateRank Clone()
		{
			return new RacingBetsUpdateRank(this);
		}

		// Token: 0x17004253 RID: 16979
		// (get) Token: 0x06013F15 RID: 81685 RVA: 0x002E742F File Offset: 0x002E562F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoId
		{
			get
			{
				return this.dangoId_;
			}
		}

		// Token: 0x06013F16 RID: 81686 RVA: 0x002E7437 File Offset: 0x002E5637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsUpdateRank);
		}

		// Token: 0x06013F17 RID: 81687 RVA: 0x002E7445 File Offset: 0x002E5645
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsUpdateRank other)
		{
			return other != null && (other == this || (this.dangoId_.Equals(other.dangoId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013F18 RID: 81688 RVA: 0x002E7478 File Offset: 0x002E5678
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.dangoId_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013F19 RID: 81689 RVA: 0x002E74AC File Offset: 0x002E56AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013F1A RID: 81690 RVA: 0x002E74B9 File Offset: 0x002E56B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013F1B RID: 81691 RVA: 0x002E74C2 File Offset: 0x002E56C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.dangoId_.WriteTo(ref output, RacingBetsUpdateRank._repeated_dangoId_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013F1C RID: 81692 RVA: 0x002E74EC File Offset: 0x002E56EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.dangoId_.CalculateSize(RacingBetsUpdateRank._repeated_dangoId_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013F1D RID: 81693 RVA: 0x002E7525 File Offset: 0x002E5725
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsUpdateRank other)
		{
			if (other == null)
			{
				return;
			}
			this.dangoId_.Add(other.dangoId_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013F1E RID: 81694 RVA: 0x002E7553 File Offset: 0x002E5753
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013F1F RID: 81695 RVA: 0x002E755C File Offset: 0x002E575C
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
				if (num != 8U && num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.dangoId_.AddEntriesFrom(ref input, RacingBetsUpdateRank._repeated_dangoId_codec);
				}
			}
		}

		// Token: 0x040079D6 RID: 31190
		private UnknownFieldSet _unknownFields;

		// Token: 0x040079D7 RID: 31191
		public const int DangoIdFieldNumber = 1;

		// Token: 0x040079D8 RID: 31192
		private static readonly FieldCodec<int> _repeated_dangoId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x040079D9 RID: 31193
		private readonly RepeatedField<int> dangoId_ = new RepeatedField<int>();
	}
}
