using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014EE RID: 5358
	[NetMessage(EMessageId.UDPMovePackageNotify)]
	public sealed class UDPMovePackageNotify : IMessage<UDPMovePackageNotify>, IMessage, IEquatable<UDPMovePackageNotify>, IDeepCloneable<UDPMovePackageNotify>, IBufferMessage
	{
		// Token: 0x0601C68C RID: 116364 RVA: 0x0041F005 File Offset: 0x0041D205
		[NullableContext(1)]
		public static UDPMovePackageNotify Create()
		{
			return new UDPMovePackageNotify();
		}

		// Token: 0x17006026 RID: 24614
		// (get) Token: 0x0601C68D RID: 116365 RVA: 0x0041F00C File Offset: 0x0041D20C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17006027 RID: 24615
		// (get) Token: 0x0601C68E RID: 116366 RVA: 0x0041F00F File Offset: 0x0041D20F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UDPMovePackageNotify.Descriptor;
			}
		}

		// Token: 0x0601C68F RID: 116367 RVA: 0x0041F016 File Offset: 0x0041D216
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackageNotify()
		{
		}

		// Token: 0x0601C690 RID: 116368 RVA: 0x0041F029 File Offset: 0x0041D229
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackageNotify(UDPMovePackageNotify other) : this()
		{
			this.movingEntities_ = other.movingEntities_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C691 RID: 116369 RVA: 0x0041F053 File Offset: 0x0041D253
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UDPMovePackageNotify Clone()
		{
			return new UDPMovePackageNotify(this);
		}

		// Token: 0x17006028 RID: 24616
		// (get) Token: 0x0601C692 RID: 116370 RVA: 0x0041F05B File Offset: 0x0041D25B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<MovingEntityData> MovingEntities
		{
			get
			{
				return this.movingEntities_;
			}
		}

		// Token: 0x0601C693 RID: 116371 RVA: 0x0041F063 File Offset: 0x0041D263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UDPMovePackageNotify);
		}

		// Token: 0x0601C694 RID: 116372 RVA: 0x0041F071 File Offset: 0x0041D271
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UDPMovePackageNotify other)
		{
			return other != null && (other == this || (this.movingEntities_.Equals(other.movingEntities_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C695 RID: 116373 RVA: 0x0041F0A4 File Offset: 0x0041D2A4
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

		// Token: 0x0601C696 RID: 116374 RVA: 0x0041F0D8 File Offset: 0x0041D2D8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C697 RID: 116375 RVA: 0x0041F0E5 File Offset: 0x0041D2E5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C698 RID: 116376 RVA: 0x0041F0EE File Offset: 0x0041D2EE
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

		// Token: 0x0601C699 RID: 116377 RVA: 0x0041F118 File Offset: 0x0041D318
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

		// Token: 0x0601C69A RID: 116378 RVA: 0x0041F151 File Offset: 0x0041D351
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

		// Token: 0x0601C69B RID: 116379 RVA: 0x0041F17F File Offset: 0x0041D37F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C69C RID: 116380 RVA: 0x0041F188 File Offset: 0x0041D388
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
				if (num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.movingEntities_.AddEntriesFrom(ref input, UDPMovePackageNotify._repeated_movingEntities_codec);
				}
			}
		}

		// Token: 0x0400A40E RID: 41998
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A40F RID: 41999
		public const int MovingEntitiesFieldNumber = 6;

		// Token: 0x0400A410 RID: 42000
		private static readonly FieldCodec<MovingEntityData> _repeated_movingEntities_codec = FieldCodec.ForMessage<MovingEntityData>(50U, MovingEntityData.Parser);

		// Token: 0x0400A411 RID: 42001
		private readonly RepeatedField<MovingEntityData> movingEntities_ = new RepeatedField<MovingEntityData>();
	}
}
