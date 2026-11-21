using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020014C6 RID: 5318
	[NetMessage(EMessageId.TrapDefenseSyncGainingGroupsNotify)]
	public sealed class TrapDefenseSyncGainingGroupsNotify : IMessage<TrapDefenseSyncGainingGroupsNotify>, IMessage, IEquatable<TrapDefenseSyncGainingGroupsNotify>, IDeepCloneable<TrapDefenseSyncGainingGroupsNotify>, IBufferMessage
	{
		// Token: 0x0601C365 RID: 115557 RVA: 0x00418416 File Offset: 0x00416616
		[NullableContext(1)]
		public static TrapDefenseSyncGainingGroupsNotify Create()
		{
			return new TrapDefenseSyncGainingGroupsNotify();
		}

		// Token: 0x17005F7C RID: 24444
		// (get) Token: 0x0601C366 RID: 115558 RVA: 0x0041841D File Offset: 0x0041661D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005F7D RID: 24445
		// (get) Token: 0x0601C367 RID: 115559 RVA: 0x00418420 File Offset: 0x00416620
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSyncGainingGroupsNotify.Descriptor;
			}
		}

		// Token: 0x0601C368 RID: 115560 RVA: 0x00418427 File Offset: 0x00416627
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSyncGainingGroupsNotify()
		{
		}

		// Token: 0x0601C369 RID: 115561 RVA: 0x0041843A File Offset: 0x0041663A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSyncGainingGroupsNotify(TrapDefenseSyncGainingGroupsNotify other) : this()
		{
			this.gainingInfos_ = other.gainingInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C36A RID: 115562 RVA: 0x00418464 File Offset: 0x00416664
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSyncGainingGroupsNotify Clone()
		{
			return new TrapDefenseSyncGainingGroupsNotify(this);
		}

		// Token: 0x17005F7E RID: 24446
		// (get) Token: 0x0601C36B RID: 115563 RVA: 0x0041846C File Offset: 0x0041666C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseGainingInfo> GainingInfos
		{
			get
			{
				return this.gainingInfos_;
			}
		}

		// Token: 0x0601C36C RID: 115564 RVA: 0x00418474 File Offset: 0x00416674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSyncGainingGroupsNotify);
		}

		// Token: 0x0601C36D RID: 115565 RVA: 0x00418482 File Offset: 0x00416682
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSyncGainingGroupsNotify other)
		{
			return other != null && (other == this || (this.gainingInfos_.Equals(other.gainingInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C36E RID: 115566 RVA: 0x004184B8 File Offset: 0x004166B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.gainingInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601C36F RID: 115567 RVA: 0x004184EC File Offset: 0x004166EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C370 RID: 115568 RVA: 0x004184F9 File Offset: 0x004166F9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C371 RID: 115569 RVA: 0x00418502 File Offset: 0x00416702
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.gainingInfos_.WriteTo(ref output, TrapDefenseSyncGainingGroupsNotify._repeated_gainingInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601C372 RID: 115570 RVA: 0x0041852C File Offset: 0x0041672C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.gainingInfos_.CalculateSize(TrapDefenseSyncGainingGroupsNotify._repeated_gainingInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601C373 RID: 115571 RVA: 0x00418565 File Offset: 0x00416765
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseSyncGainingGroupsNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.gainingInfos_.Add(other.gainingInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601C374 RID: 115572 RVA: 0x00418593 File Offset: 0x00416793
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C375 RID: 115573 RVA: 0x0041859C File Offset: 0x0041679C
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
				if (num != 34U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.gainingInfos_.AddEntriesFrom(ref input, TrapDefenseSyncGainingGroupsNotify._repeated_gainingInfos_codec);
				}
			}
		}

		// Token: 0x0400A31B RID: 41755
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A31C RID: 41756
		public const int GainingInfosFieldNumber = 4;

		// Token: 0x0400A31D RID: 41757
		private static readonly FieldCodec<TrapDefenseGainingInfo> _repeated_gainingInfos_codec = FieldCodec.ForMessage<TrapDefenseGainingInfo>(34U, TrapDefenseGainingInfo.Parser);

		// Token: 0x0400A31E RID: 41758
		private readonly RepeatedField<TrapDefenseGainingInfo> gainingInfos_ = new RepeatedField<TrapDefenseGainingInfo>();
	}
}
