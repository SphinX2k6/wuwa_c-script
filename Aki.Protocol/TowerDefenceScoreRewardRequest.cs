using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001424 RID: 5156
	[NetMessage(EMessageId.TowerDefenceScoreRewardRequest)]
	public sealed class TowerDefenceScoreRewardRequest : IMessage<TowerDefenceScoreRewardRequest>, IMessage, IEquatable<TowerDefenceScoreRewardRequest>, IDeepCloneable<TowerDefenceScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B67F RID: 112255 RVA: 0x003FC423 File Offset: 0x003FA623
		[NullableContext(1)]
		public static TowerDefenceScoreRewardRequest Create()
		{
			return new TowerDefenceScoreRewardRequest();
		}

		// Token: 0x17005CCB RID: 23755
		// (get) Token: 0x0601B680 RID: 112256 RVA: 0x003FC42A File Offset: 0x003FA62A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CCC RID: 23756
		// (get) Token: 0x0601B681 RID: 112257 RVA: 0x003FC42D File Offset: 0x003FA62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B682 RID: 112258 RVA: 0x003FC434 File Offset: 0x003FA634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardRequest()
		{
		}

		// Token: 0x0601B683 RID: 112259 RVA: 0x003FC447 File Offset: 0x003FA647
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardRequest(TowerDefenceScoreRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B684 RID: 112260 RVA: 0x003FC471 File Offset: 0x003FA671
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardRequest Clone()
		{
			return new TowerDefenceScoreRewardRequest(this);
		}

		// Token: 0x17005CCD RID: 23757
		// (get) Token: 0x0601B685 RID: 112261 RVA: 0x003FC479 File Offset: 0x003FA679
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601B686 RID: 112262 RVA: 0x003FC481 File Offset: 0x003FA681
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceScoreRewardRequest);
		}

		// Token: 0x0601B687 RID: 112263 RVA: 0x003FC48F File Offset: 0x003FA68F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B688 RID: 112264 RVA: 0x003FC4C4 File Offset: 0x003FA6C4
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

		// Token: 0x0601B689 RID: 112265 RVA: 0x003FC4F8 File Offset: 0x003FA6F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B68A RID: 112266 RVA: 0x003FC505 File Offset: 0x003FA705
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B68B RID: 112267 RVA: 0x003FC50E File Offset: 0x003FA70E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TowerDefenceScoreRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B68C RID: 112268 RVA: 0x003FC538 File Offset: 0x003FA738
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TowerDefenceScoreRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B68D RID: 112269 RVA: 0x003FC571 File Offset: 0x003FA771
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceScoreRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B68E RID: 112270 RVA: 0x003FC59F File Offset: 0x003FA79F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B68F RID: 112271 RVA: 0x003FC5A8 File Offset: 0x003FA7A8
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
				if (num != 88U && num != 90U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TowerDefenceScoreRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009F9B RID: 40859
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F9C RID: 40860
		public const int IdsFieldNumber = 11;

		// Token: 0x04009F9D RID: 40861
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04009F9E RID: 40862
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
