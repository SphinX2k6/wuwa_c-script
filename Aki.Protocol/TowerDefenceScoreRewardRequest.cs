using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013B1 RID: 5041
	[NetMessage(EMessageId.TowerDefenceScoreRewardRequest)]
	public sealed class TowerDefenceScoreRewardRequest : IMessage<TowerDefenceScoreRewardRequest>, IMessage, IEquatable<TowerDefenceScoreRewardRequest>, IDeepCloneable<TowerDefenceScoreRewardRequest>, IBufferMessage
	{
		// Token: 0x0601ABF4 RID: 109556 RVA: 0x003E1163 File Offset: 0x003DF363
		[NullableContext(1)]
		public static TowerDefenceScoreRewardRequest Create()
		{
			return new TowerDefenceScoreRewardRequest();
		}

		// Token: 0x17005A36 RID: 23094
		// (get) Token: 0x0601ABF5 RID: 109557 RVA: 0x003E116A File Offset: 0x003DF36A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A37 RID: 23095
		// (get) Token: 0x0601ABF6 RID: 109558 RVA: 0x003E116D File Offset: 0x003DF36D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceScoreRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601ABF7 RID: 109559 RVA: 0x003E1174 File Offset: 0x003DF374
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardRequest()
		{
		}

		// Token: 0x0601ABF8 RID: 109560 RVA: 0x003E1187 File Offset: 0x003DF387
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardRequest(TowerDefenceScoreRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601ABF9 RID: 109561 RVA: 0x003E11B1 File Offset: 0x003DF3B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceScoreRewardRequest Clone()
		{
			return new TowerDefenceScoreRewardRequest(this);
		}

		// Token: 0x17005A38 RID: 23096
		// (get) Token: 0x0601ABFA RID: 109562 RVA: 0x003E11B9 File Offset: 0x003DF3B9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601ABFB RID: 109563 RVA: 0x003E11C1 File Offset: 0x003DF3C1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceScoreRewardRequest);
		}

		// Token: 0x0601ABFC RID: 109564 RVA: 0x003E11CF File Offset: 0x003DF3CF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceScoreRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601ABFD RID: 109565 RVA: 0x003E1204 File Offset: 0x003DF404
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

		// Token: 0x0601ABFE RID: 109566 RVA: 0x003E1238 File Offset: 0x003DF438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601ABFF RID: 109567 RVA: 0x003E1245 File Offset: 0x003DF445
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AC00 RID: 109568 RVA: 0x003E124E File Offset: 0x003DF44E
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

		// Token: 0x0601AC01 RID: 109569 RVA: 0x003E1278 File Offset: 0x003DF478
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

		// Token: 0x0601AC02 RID: 109570 RVA: 0x003E12B1 File Offset: 0x003DF4B1
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

		// Token: 0x0601AC03 RID: 109571 RVA: 0x003E12DF File Offset: 0x003DF4DF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AC04 RID: 109572 RVA: 0x003E12E8 File Offset: 0x003DF4E8
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
				if (num != 48U && num != 50U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TowerDefenceScoreRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009B54 RID: 39764
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B55 RID: 39765
		public const int IdsFieldNumber = 6;

		// Token: 0x04009B56 RID: 39766
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(50U);

		// Token: 0x04009B57 RID: 39767
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
