using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001453 RID: 5203
	[NetMessage(EMessageId.TrapDefenseSyncGainingGroupsNotify)]
	public sealed class TrapDefenseSyncGainingGroupsNotify : IMessage<TrapDefenseSyncGainingGroupsNotify>, IMessage, IEquatable<TrapDefenseSyncGainingGroupsNotify>, IDeepCloneable<TrapDefenseSyncGainingGroupsNotify>, IBufferMessage
	{
		// Token: 0x0601B8DA RID: 112858 RVA: 0x003FD146 File Offset: 0x003FB346
		[NullableContext(1)]
		public static TrapDefenseSyncGainingGroupsNotify Create()
		{
			return new TrapDefenseSyncGainingGroupsNotify();
		}

		// Token: 0x17005CE7 RID: 23783
		// (get) Token: 0x0601B8DB RID: 112859 RVA: 0x003FD14D File Offset: 0x003FB34D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CE8 RID: 23784
		// (get) Token: 0x0601B8DC RID: 112860 RVA: 0x003FD150 File Offset: 0x003FB350
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseSyncGainingGroupsNotify.Descriptor;
			}
		}

		// Token: 0x0601B8DD RID: 112861 RVA: 0x003FD157 File Offset: 0x003FB357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSyncGainingGroupsNotify()
		{
		}

		// Token: 0x0601B8DE RID: 112862 RVA: 0x003FD16A File Offset: 0x003FB36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSyncGainingGroupsNotify(TrapDefenseSyncGainingGroupsNotify other) : this()
		{
			this.gainingInfos_ = other.gainingInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B8DF RID: 112863 RVA: 0x003FD194 File Offset: 0x003FB394
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseSyncGainingGroupsNotify Clone()
		{
			return new TrapDefenseSyncGainingGroupsNotify(this);
		}

		// Token: 0x17005CE9 RID: 23785
		// (get) Token: 0x0601B8E0 RID: 112864 RVA: 0x003FD19C File Offset: 0x003FB39C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TrapDefenseGainingInfo> GainingInfos
		{
			get
			{
				return this.gainingInfos_;
			}
		}

		// Token: 0x0601B8E1 RID: 112865 RVA: 0x003FD1A4 File Offset: 0x003FB3A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseSyncGainingGroupsNotify);
		}

		// Token: 0x0601B8E2 RID: 112866 RVA: 0x003FD1B2 File Offset: 0x003FB3B2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseSyncGainingGroupsNotify other)
		{
			return other != null && (other == this || (this.gainingInfos_.Equals(other.gainingInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B8E3 RID: 112867 RVA: 0x003FD1E8 File Offset: 0x003FB3E8
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

		// Token: 0x0601B8E4 RID: 112868 RVA: 0x003FD21C File Offset: 0x003FB41C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B8E5 RID: 112869 RVA: 0x003FD229 File Offset: 0x003FB429
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B8E6 RID: 112870 RVA: 0x003FD232 File Offset: 0x003FB432
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

		// Token: 0x0601B8E7 RID: 112871 RVA: 0x003FD25C File Offset: 0x003FB45C
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

		// Token: 0x0601B8E8 RID: 112872 RVA: 0x003FD295 File Offset: 0x003FB495
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

		// Token: 0x0601B8E9 RID: 112873 RVA: 0x003FD2C3 File Offset: 0x003FB4C3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B8EA RID: 112874 RVA: 0x003FD2CC File Offset: 0x003FB4CC
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

		// Token: 0x04009ED4 RID: 40660
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009ED5 RID: 40661
		public const int GainingInfosFieldNumber = 4;

		// Token: 0x04009ED6 RID: 40662
		private static readonly FieldCodec<TrapDefenseGainingInfo> _repeated_gainingInfos_codec = FieldCodec.ForMessage<TrapDefenseGainingInfo>(34U, TrapDefenseGainingInfo.Parser);

		// Token: 0x04009ED7 RID: 40663
		private readonly RepeatedField<TrapDefenseGainingInfo> gainingInfos_ = new RepeatedField<TrapDefenseGainingInfo>();
	}
}
