using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200147B RID: 5243
	[NetMessage(EMessageId.UDPMovePackageNotify)]
	public sealed class UDPMovePackageNotify : IMessage<UDPMovePackageNotify>, IMessage, IEquatable<UDPMovePackageNotify>, IDeepCloneable<UDPMovePackageNotify>, IBufferMessage
	{
		// Token: 0x0601BC01 RID: 113665 RVA: 0x00403D41 File Offset: 0x00401F41
		[NullableContext(1)]
		public static UDPMovePackageNotify Create()
		{
			return new UDPMovePackageNotify();
		}

		// Token: 0x17005D91 RID: 23953
		// (get) Token: 0x0601BC02 RID: 113666 RVA: 0x00403D48 File Offset: 0x00401F48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005D92 RID: 23954
		// (get) Token: 0x0601BC03 RID: 113667 RVA: 0x00403D4B File Offset: 0x00401F4B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UDPMovePackageNotify.Descriptor;
			}
		}

		// Token: 0x0601BC04 RID: 113668 RVA: 0x00403D52 File Offset: 0x00401F52
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackageNotify()
		{
		}

		// Token: 0x0601BC05 RID: 113669 RVA: 0x00403D65 File Offset: 0x00401F65
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackageNotify(UDPMovePackageNotify other) : this()
		{
			this.movingEntities_ = other.movingEntities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BC06 RID: 113670 RVA: 0x00403D8F File Offset: 0x00401F8F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackageNotify Clone()
		{
			return new UDPMovePackageNotify(this);
		}

		// Token: 0x17005D93 RID: 23955
		// (get) Token: 0x0601BC07 RID: 113671 RVA: 0x00403D97 File Offset: 0x00401F97
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MovingEntityData> MovingEntities
		{
			get
			{
				return this.movingEntities_;
			}
		}

		// Token: 0x0601BC08 RID: 113672 RVA: 0x00403D9F File Offset: 0x00401F9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UDPMovePackageNotify);
		}

		// Token: 0x0601BC09 RID: 113673 RVA: 0x00403DAD File Offset: 0x00401FAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UDPMovePackageNotify other)
		{
			return other != null && (other == this || (this.movingEntities_.Equals(other.movingEntities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BC0A RID: 113674 RVA: 0x00403DE0 File Offset: 0x00401FE0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.movingEntities_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BC0B RID: 113675 RVA: 0x00403E14 File Offset: 0x00402014
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BC0C RID: 113676 RVA: 0x00403E21 File Offset: 0x00402021
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BC0D RID: 113677 RVA: 0x00403E2A File Offset: 0x0040202A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.movingEntities_.WriteTo(ref output, UDPMovePackageNotify._repeated_movingEntities_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BC0E RID: 113678 RVA: 0x00403E54 File Offset: 0x00402054
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.movingEntities_.CalculateSize(UDPMovePackageNotify._repeated_movingEntities_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BC0F RID: 113679 RVA: 0x00403E8D File Offset: 0x0040208D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UDPMovePackageNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.movingEntities_.Add(other.movingEntities_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BC10 RID: 113680 RVA: 0x00403EBB File Offset: 0x004020BB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BC11 RID: 113681 RVA: 0x00403EC4 File Offset: 0x004020C4
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.movingEntities_.AddEntriesFrom(ref input, UDPMovePackageNotify._repeated_movingEntities_codec);
				}
			}
		}

		// Token: 0x04009FC7 RID: 40903
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FC8 RID: 40904
		public const int MovingEntitiesFieldNumber = 8;

		// Token: 0x04009FC9 RID: 40905
		private static readonly FieldCodec<MovingEntityData> _repeated_movingEntities_codec = FieldCodec.ForMessage<MovingEntityData>(66U, MovingEntityData.Parser);

		// Token: 0x04009FCA RID: 40906
		private readonly RepeatedField<MovingEntityData> movingEntities_ = new RepeatedField<MovingEntityData>();
	}
}
