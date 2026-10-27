using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001429 RID: 5161
	[NetMessage(EMessageId.TrapDefenseGetSpecialRewardRequest)]
	public sealed class TrapDefenseGetSpecialRewardRequest : IMessage<TrapDefenseGetSpecialRewardRequest>, IMessage, IEquatable<TrapDefenseGetSpecialRewardRequest>, IDeepCloneable<TrapDefenseGetSpecialRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B595 RID: 112021 RVA: 0x003F63A9 File Offset: 0x003F45A9
		[NullableContext(1)]
		public static TrapDefenseGetSpecialRewardRequest Create()
		{
			return new TrapDefenseGetSpecialRewardRequest();
		}

		// Token: 0x17005C3D RID: 23613
		// (get) Token: 0x0601B596 RID: 112022 RVA: 0x003F63B0 File Offset: 0x003F45B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C3E RID: 23614
		// (get) Token: 0x0601B597 RID: 112023 RVA: 0x003F63B3 File Offset: 0x003F45B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGetSpecialRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B598 RID: 112024 RVA: 0x003F63BA File Offset: 0x003F45BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardRequest()
		{
		}

		// Token: 0x0601B599 RID: 112025 RVA: 0x003F63CD File Offset: 0x003F45CD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardRequest(TrapDefenseGetSpecialRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B59A RID: 112026 RVA: 0x003F63F7 File Offset: 0x003F45F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardRequest Clone()
		{
			return new TrapDefenseGetSpecialRewardRequest(this);
		}

		// Token: 0x17005C3F RID: 23615
		// (get) Token: 0x0601B59B RID: 112027 RVA: 0x003F63FF File Offset: 0x003F45FF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601B59C RID: 112028 RVA: 0x003F6407 File Offset: 0x003F4607
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGetSpecialRewardRequest);
		}

		// Token: 0x0601B59D RID: 112029 RVA: 0x003F6415 File Offset: 0x003F4615
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGetSpecialRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B59E RID: 112030 RVA: 0x003F6448 File Offset: 0x003F4648
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.ids_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B59F RID: 112031 RVA: 0x003F647C File Offset: 0x003F467C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5A0 RID: 112032 RVA: 0x003F6489 File Offset: 0x003F4689
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5A1 RID: 112033 RVA: 0x003F6492 File Offset: 0x003F4692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TrapDefenseGetSpecialRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B5A2 RID: 112034 RVA: 0x003F64BC File Offset: 0x003F46BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TrapDefenseGetSpecialRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B5A3 RID: 112035 RVA: 0x003F64F5 File Offset: 0x003F46F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TrapDefenseGetSpecialRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B5A4 RID: 112036 RVA: 0x003F6523 File Offset: 0x003F4723
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B5A5 RID: 112037 RVA: 0x003F652C File Offset: 0x003F472C
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
					this.ids_.AddEntriesFrom(ref input, TrapDefenseGetSpecialRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009DFC RID: 40444
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009DFD RID: 40445
		public const int IdsFieldNumber = 1;

		// Token: 0x04009DFE RID: 40446
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(10U);

		// Token: 0x04009DFF RID: 40447
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
