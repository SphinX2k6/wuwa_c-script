using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A2 RID: 5026
	[NetMessage(EMessageId.TowerDefenceInstanceRewardRequest)]
	public sealed class TowerDefenceInstanceRewardRequest : IMessage<TowerDefenceInstanceRewardRequest>, IMessage, IEquatable<TowerDefenceInstanceRewardRequest>, IDeepCloneable<TowerDefenceInstanceRewardRequest>, IBufferMessage
	{
		// Token: 0x0601AAB4 RID: 109236 RVA: 0x003DE4B5 File Offset: 0x003DC6B5
		[NullableContext(1)]
		public static TowerDefenceInstanceRewardRequest Create()
		{
			return new TowerDefenceInstanceRewardRequest();
		}

		// Token: 0x170059EE RID: 23022
		// (get) Token: 0x0601AAB5 RID: 109237 RVA: 0x003DE4BC File Offset: 0x003DC6BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059EF RID: 23023
		// (get) Token: 0x0601AAB6 RID: 109238 RVA: 0x003DE4BF File Offset: 0x003DC6BF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceInstanceRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601AAB7 RID: 109239 RVA: 0x003DE4C6 File Offset: 0x003DC6C6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardRequest()
		{
		}

		// Token: 0x0601AAB8 RID: 109240 RVA: 0x003DE4D9 File Offset: 0x003DC6D9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardRequest(TowerDefenceInstanceRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AAB9 RID: 109241 RVA: 0x003DE503 File Offset: 0x003DC703
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardRequest Clone()
		{
			return new TowerDefenceInstanceRewardRequest(this);
		}

		// Token: 0x170059F0 RID: 23024
		// (get) Token: 0x0601AABA RID: 109242 RVA: 0x003DE50B File Offset: 0x003DC70B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601AABB RID: 109243 RVA: 0x003DE513 File Offset: 0x003DC713
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceInstanceRewardRequest);
		}

		// Token: 0x0601AABC RID: 109244 RVA: 0x003DE521 File Offset: 0x003DC721
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceInstanceRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AABD RID: 109245 RVA: 0x003DE554 File Offset: 0x003DC754
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

		// Token: 0x0601AABE RID: 109246 RVA: 0x003DE588 File Offset: 0x003DC788
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AABF RID: 109247 RVA: 0x003DE595 File Offset: 0x003DC795
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AAC0 RID: 109248 RVA: 0x003DE59E File Offset: 0x003DC79E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.ids_.WriteTo(ref output, TowerDefenceInstanceRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AAC1 RID: 109249 RVA: 0x003DE5C8 File Offset: 0x003DC7C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.ids_.CalculateSize(TowerDefenceInstanceRewardRequest._repeated_ids_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AAC2 RID: 109250 RVA: 0x003DE601 File Offset: 0x003DC801
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceInstanceRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			this.ids_.Add(other.ids_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AAC3 RID: 109251 RVA: 0x003DE62F File Offset: 0x003DC82F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AAC4 RID: 109252 RVA: 0x003DE638 File Offset: 0x003DC838
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
				if (num != 112U && num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.ids_.AddEntriesFrom(ref input, TowerDefenceInstanceRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009AEE RID: 39662
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AEF RID: 39663
		public const int IdsFieldNumber = 14;

		// Token: 0x04009AF0 RID: 39664
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(114U);

		// Token: 0x04009AF1 RID: 39665
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
