using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200065E RID: 1630
	public sealed class FRUnitActions : IMessage<FRUnitActions>, IMessage, IEquatable<FRUnitActions>, IDeepCloneable<FRUnitActions>, IBufferMessage
	{
		// Token: 0x060095A4 RID: 38308 RVA: 0x0016925E File Offset: 0x0016745E
		[NullableContext(1)]
		public static FRUnitActions Create()
		{
			return new FRUnitActions();
		}

		// Token: 0x17001DC7 RID: 7623
		// (get) Token: 0x060095A5 RID: 38309 RVA: 0x00169265 File Offset: 0x00167465
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DC8 RID: 7624
		// (get) Token: 0x060095A6 RID: 38310 RVA: 0x00169268 File Offset: 0x00167468
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitActions.Descriptor;
			}
		}

		// Token: 0x060095A7 RID: 38311 RVA: 0x0016926F File Offset: 0x0016746F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitActions()
		{
		}

		// Token: 0x060095A8 RID: 38312 RVA: 0x00169282 File Offset: 0x00167482
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitActions(FRUnitActions other) : this()
		{
			this.unitActions_ = other.unitActions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095A9 RID: 38313 RVA: 0x001692AC File Offset: 0x001674AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitActions Clone()
		{
			return new FRUnitActions(this);
		}

		// Token: 0x17001DC9 RID: 7625
		// (get) Token: 0x060095AA RID: 38314 RVA: 0x001692B4 File Offset: 0x001674B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FloroRanchUnitActionMsg> UnitActions
		{
			get
			{
				return this.unitActions_;
			}
		}

		// Token: 0x060095AB RID: 38315 RVA: 0x001692BC File Offset: 0x001674BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitActions);
		}

		// Token: 0x060095AC RID: 38316 RVA: 0x001692CA File Offset: 0x001674CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitActions other)
		{
			return other != null && (other == this || (this.unitActions_.Equals(other.unitActions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095AD RID: 38317 RVA: 0x00169300 File Offset: 0x00167500
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

		// Token: 0x060095AE RID: 38318 RVA: 0x00169334 File Offset: 0x00167534
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060095AF RID: 38319 RVA: 0x00169341 File Offset: 0x00167541
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095B0 RID: 38320 RVA: 0x0016934A File Offset: 0x0016754A
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

		// Token: 0x060095B1 RID: 38321 RVA: 0x00169374 File Offset: 0x00167574
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

		// Token: 0x060095B2 RID: 38322 RVA: 0x001693AD File Offset: 0x001675AD
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

		// Token: 0x060095B3 RID: 38323 RVA: 0x001693DB File Offset: 0x001675DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095B4 RID: 38324 RVA: 0x001693E4 File Offset: 0x001675E4
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

		// Token: 0x04004772 RID: 18290
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004773 RID: 18291
		public const int UnitActionsFieldNumber = 1;

		// Token: 0x04004774 RID: 18292
		private static readonly FieldCodec<FloroRanchUnitActionMsg> _repeated_unitActions_codec = FieldCodec.ForMessage<FloroRanchUnitActionMsg>(10U, FloroRanchUnitActionMsg.Parser);

		// Token: 0x04004775 RID: 18293
		private readonly RepeatedField<FloroRanchUnitActionMsg> unitActions_ = new RepeatedField<FloroRanchUnitActionMsg>();
	}
}
