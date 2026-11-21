using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E71 RID: 3697
	public sealed class RacingBetsUpdateRank : IMessage<RacingBetsUpdateRank>, IMessage, IEquatable<RacingBetsUpdateRank>, IDeepCloneable<RacingBetsUpdateRank>, IBufferMessage
	{
		// Token: 0x06013E2A RID: 81450 RVA: 0x002E5D1D File Offset: 0x002E3F1D
		[NullableContext(1)]
		public static RacingBetsUpdateRank Create()
		{
			return new RacingBetsUpdateRank();
		}

		// Token: 0x17004227 RID: 16935
		// (get) Token: 0x06013E2B RID: 81451 RVA: 0x002E5D24 File Offset: 0x002E3F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004228 RID: 16936
		// (get) Token: 0x06013E2C RID: 81452 RVA: 0x002E5D27 File Offset: 0x002E3F27
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsUpdateRank.Descriptor;
			}
		}

		// Token: 0x06013E2D RID: 81453 RVA: 0x002E5D2E File Offset: 0x002E3F2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateRank()
		{
		}

		// Token: 0x06013E2E RID: 81454 RVA: 0x002E5D41 File Offset: 0x002E3F41
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateRank(RacingBetsUpdateRank other) : this()
		{
			this.dangoId_ = other.dangoId_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013E2F RID: 81455 RVA: 0x002E5D6B File Offset: 0x002E3F6B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsUpdateRank Clone()
		{
			return new RacingBetsUpdateRank(this);
		}

		// Token: 0x17004229 RID: 16937
		// (get) Token: 0x06013E30 RID: 81456 RVA: 0x002E5D73 File Offset: 0x002E3F73
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> DangoId
		{
			get
			{
				return this.dangoId_;
			}
		}

		// Token: 0x06013E31 RID: 81457 RVA: 0x002E5D7B File Offset: 0x002E3F7B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsUpdateRank);
		}

		// Token: 0x06013E32 RID: 81458 RVA: 0x002E5D89 File Offset: 0x002E3F89
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsUpdateRank other)
		{
			return other != null && (other == this || (this.dangoId_.Equals(other.dangoId_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013E33 RID: 81459 RVA: 0x002E5DBC File Offset: 0x002E3FBC
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

		// Token: 0x06013E34 RID: 81460 RVA: 0x002E5DF0 File Offset: 0x002E3FF0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013E35 RID: 81461 RVA: 0x002E5DFD File Offset: 0x002E3FFD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013E36 RID: 81462 RVA: 0x002E5E06 File Offset: 0x002E4006
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

		// Token: 0x06013E37 RID: 81463 RVA: 0x002E5E30 File Offset: 0x002E4030
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

		// Token: 0x06013E38 RID: 81464 RVA: 0x002E5E69 File Offset: 0x002E4069
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

		// Token: 0x06013E39 RID: 81465 RVA: 0x002E5E97 File Offset: 0x002E4097
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013E3A RID: 81466 RVA: 0x002E5EA0 File Offset: 0x002E40A0
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

		// Token: 0x04007A00 RID: 31232
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007A01 RID: 31233
		public const int DangoIdFieldNumber = 1;

		// Token: 0x04007A02 RID: 31234
		private static readonly FieldCodec<int> _repeated_dangoId_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04007A03 RID: 31235
		private readonly RepeatedField<int> dangoId_ = new RepeatedField<int>();
	}
}
