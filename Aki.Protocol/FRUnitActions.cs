using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200064A RID: 1610
	public sealed class FRUnitActions : IMessage<FRUnitActions>, IMessage, IEquatable<FRUnitActions>, IDeepCloneable<FRUnitActions>, IBufferMessage
	{
		// Token: 0x0600944E RID: 37966 RVA: 0x00166832 File Offset: 0x00164A32
		[NullableContext(1)]
		public static FRUnitActions Create()
		{
			return new FRUnitActions();
		}

		// Token: 0x17001D7D RID: 7549
		// (get) Token: 0x0600944F RID: 37967 RVA: 0x00166839 File Offset: 0x00164A39
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001D7E RID: 7550
		// (get) Token: 0x06009450 RID: 37968 RVA: 0x0016683C File Offset: 0x00164A3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitActions.Descriptor;
			}
		}

		// Token: 0x06009451 RID: 37969 RVA: 0x00166843 File Offset: 0x00164A43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitActions()
		{
		}

		// Token: 0x06009452 RID: 37970 RVA: 0x00166856 File Offset: 0x00164A56
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitActions(FRUnitActions other) : this()
		{
			this.unitActions_ = other.unitActions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06009453 RID: 37971 RVA: 0x00166880 File Offset: 0x00164A80
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitActions Clone()
		{
			return new FRUnitActions(this);
		}

		// Token: 0x17001D7F RID: 7551
		// (get) Token: 0x06009454 RID: 37972 RVA: 0x00166888 File Offset: 0x00164A88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchUnitActionMsg> UnitActions
		{
			get
			{
				return this.unitActions_;
			}
		}

		// Token: 0x06009455 RID: 37973 RVA: 0x00166890 File Offset: 0x00164A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitActions);
		}

		// Token: 0x06009456 RID: 37974 RVA: 0x0016689E File Offset: 0x00164A9E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitActions other)
		{
			return other != null && (other == this || (this.unitActions_.Equals(other.unitActions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06009457 RID: 37975 RVA: 0x001668D4 File Offset: 0x00164AD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.unitActions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06009458 RID: 37976 RVA: 0x00166908 File Offset: 0x00164B08
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06009459 RID: 37977 RVA: 0x00166915 File Offset: 0x00164B15
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600945A RID: 37978 RVA: 0x0016691E File Offset: 0x00164B1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.unitActions_.WriteTo(ref output, FRUnitActions._repeated_unitActions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600945B RID: 37979 RVA: 0x00166948 File Offset: 0x00164B48
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.unitActions_.CalculateSize(FRUnitActions._repeated_unitActions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600945C RID: 37980 RVA: 0x00166981 File Offset: 0x00164B81
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRUnitActions other)
		{
			if (other == null)
			{
				return;
			}
			this.unitActions_.Add(other.unitActions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600945D RID: 37981 RVA: 0x001669AF File Offset: 0x00164BAF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600945E RID: 37982 RVA: 0x001669B8 File Offset: 0x00164BB8
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
					this.unitActions_.AddEntriesFrom(ref input, FRUnitActions._repeated_unitActions_codec);
				}
			}
		}

		// Token: 0x0400476B RID: 18283
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400476C RID: 18284
		public const int UnitActionsFieldNumber = 1;

		// Token: 0x0400476D RID: 18285
		private static readonly FieldCodec<FloroRanchUnitActionMsg> _repeated_unitActions_codec = FieldCodec.ForMessage<FloroRanchUnitActionMsg>(10U, FloroRanchUnitActionMsg.Parser);

		// Token: 0x0400476E RID: 18286
		private readonly RepeatedField<FloroRanchUnitActionMsg> unitActions_ = new RepeatedField<FloroRanchUnitActionMsg>();
	}
}
