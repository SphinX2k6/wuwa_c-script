using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000661 RID: 1633
	public sealed class FRUnitEatingActionGroup : IMessage<FRUnitEatingActionGroup>, IMessage, IEquatable<FRUnitEatingActionGroup>, IDeepCloneable<FRUnitEatingActionGroup>, IBufferMessage
	{
		// Token: 0x060095DF RID: 38367 RVA: 0x001699D7 File Offset: 0x00167BD7
		[NullableContext(1)]
		public static FRUnitEatingActionGroup Create()
		{
			return new FRUnitEatingActionGroup();
		}

		// Token: 0x17001DD3 RID: 7635
		// (get) Token: 0x060095E0 RID: 38368 RVA: 0x001699DE File Offset: 0x00167BDE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17001DD4 RID: 7636
		// (get) Token: 0x060095E1 RID: 38369 RVA: 0x001699E1 File Offset: 0x00167BE1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return FRUnitEatingActionGroup.Descriptor;
			}
		}

		// Token: 0x060095E2 RID: 38370 RVA: 0x001699E8 File Offset: 0x00167BE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingActionGroup()
		{
		}

		// Token: 0x060095E3 RID: 38371 RVA: 0x001699FB File Offset: 0x00167BFB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingActionGroup(FRUnitEatingActionGroup other) : this()
		{
			this.actions_ = other.actions_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x060095E4 RID: 38372 RVA: 0x00169A25 File Offset: 0x00167C25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public FRUnitEatingActionGroup Clone()
		{
			return new FRUnitEatingActionGroup(this);
		}

		// Token: 0x17001DD5 RID: 7637
		// (get) Token: 0x060095E5 RID: 38373 RVA: 0x00169A2D File Offset: 0x00167C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<FRUnitEatingAction> Actions
		{
			get
			{
				return this.actions_;
			}
		}

		// Token: 0x060095E6 RID: 38374 RVA: 0x00169A35 File Offset: 0x00167C35
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as FRUnitEatingActionGroup);
		}

		// Token: 0x060095E7 RID: 38375 RVA: 0x00169A43 File Offset: 0x00167C43
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(FRUnitEatingActionGroup other)
		{
			return other != null && (other == this || (this.actions_.Equals(other.actions_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060095E8 RID: 38376 RVA: 0x00169A78 File Offset: 0x00167C78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.actions_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x060095E9 RID: 38377 RVA: 0x00169AAC File Offset: 0x00167CAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060095EA RID: 38378 RVA: 0x00169AB9 File Offset: 0x00167CB9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060095EB RID: 38379 RVA: 0x00169AC2 File Offset: 0x00167CC2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.actions_.WriteTo(ref output, FRUnitEatingActionGroup._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x060095EC RID: 38380 RVA: 0x00169AEC File Offset: 0x00167CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.actions_.CalculateSize(FRUnitEatingActionGroup._repeated_actions_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x060095ED RID: 38381 RVA: 0x00169B25 File Offset: 0x00167D25
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(FRUnitEatingActionGroup other)
		{
			if (other == null)
			{
				return;
			}
			this.actions_.Add(other.actions_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x060095EE RID: 38382 RVA: 0x00169B53 File Offset: 0x00167D53
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060095EF RID: 38383 RVA: 0x00169B5C File Offset: 0x00167D5C
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
					this.actions_.AddEntriesFrom(ref input, FRUnitEatingActionGroup._repeated_actions_codec);
				}
			}
		}

		// Token: 0x04004783 RID: 18307
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004784 RID: 18308
		public const int ActionsFieldNumber = 1;

		// Token: 0x04004785 RID: 18309
		private static readonly FieldCodec<FRUnitEatingAction> _repeated_actions_codec = FieldCodec.ForMessage<FRUnitEatingAction>(10U, FRUnitEatingAction.Parser);

		// Token: 0x04004786 RID: 18310
		private readonly RepeatedField<FRUnitEatingAction> actions_ = new RepeatedField<FRUnitEatingAction>();
	}
}
