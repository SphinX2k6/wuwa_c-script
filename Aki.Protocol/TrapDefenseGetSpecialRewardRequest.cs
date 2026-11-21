using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149C RID: 5276
	[NetMessage(EMessageId.TrapDefenseGetSpecialRewardRequest)]
	public sealed class TrapDefenseGetSpecialRewardRequest : IMessage<TrapDefenseGetSpecialRewardRequest>, IMessage, IEquatable<TrapDefenseGetSpecialRewardRequest>, IDeepCloneable<TrapDefenseGetSpecialRewardRequest>, IBufferMessage
	{
		// Token: 0x0601C020 RID: 114720 RVA: 0x0041167D File Offset: 0x0040F87D
		[NullableContext(1)]
		public static TrapDefenseGetSpecialRewardRequest Create()
		{
			return new TrapDefenseGetSpecialRewardRequest();
		}

		// Token: 0x17005ED2 RID: 24274
		// (get) Token: 0x0601C021 RID: 114721 RVA: 0x00411684 File Offset: 0x0040F884
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005ED3 RID: 24275
		// (get) Token: 0x0601C022 RID: 114722 RVA: 0x00411687 File Offset: 0x0040F887
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TrapDefenseGetSpecialRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601C023 RID: 114723 RVA: 0x0041168E File Offset: 0x0040F88E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardRequest()
		{
		}

		// Token: 0x0601C024 RID: 114724 RVA: 0x004116A1 File Offset: 0x0040F8A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardRequest(TrapDefenseGetSpecialRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601C025 RID: 114725 RVA: 0x004116CB File Offset: 0x0040F8CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TrapDefenseGetSpecialRewardRequest Clone()
		{
			return new TrapDefenseGetSpecialRewardRequest(this);
		}

		// Token: 0x17005ED4 RID: 24276
		// (get) Token: 0x0601C026 RID: 114726 RVA: 0x004116D3 File Offset: 0x0040F8D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601C027 RID: 114727 RVA: 0x004116DB File Offset: 0x0040F8DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TrapDefenseGetSpecialRewardRequest);
		}

		// Token: 0x0601C028 RID: 114728 RVA: 0x004116E9 File Offset: 0x0040F8E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TrapDefenseGetSpecialRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601C029 RID: 114729 RVA: 0x0041171C File Offset: 0x0040F91C
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

		// Token: 0x0601C02A RID: 114730 RVA: 0x00411750 File Offset: 0x0040F950
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601C02B RID: 114731 RVA: 0x0041175D File Offset: 0x0040F95D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601C02C RID: 114732 RVA: 0x00411766 File Offset: 0x0040F966
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

		// Token: 0x0601C02D RID: 114733 RVA: 0x00411790 File Offset: 0x0040F990
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

		// Token: 0x0601C02E RID: 114734 RVA: 0x004117C9 File Offset: 0x0040F9C9
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

		// Token: 0x0601C02F RID: 114735 RVA: 0x004117F7 File Offset: 0x0040F9F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601C030 RID: 114736 RVA: 0x00411800 File Offset: 0x0040FA00
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
				if (num != 40U && num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TrapDefenseGetSpecialRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x0400A243 RID: 41539
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A244 RID: 41540
		public const int IdsFieldNumber = 5;

		// Token: 0x0400A245 RID: 41541
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(42U);

		// Token: 0x0400A246 RID: 41542
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
