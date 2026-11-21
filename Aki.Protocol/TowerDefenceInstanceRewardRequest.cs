using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001415 RID: 5141
	[NetMessage(EMessageId.TowerDefenceInstanceRewardRequest)]
	public sealed class TowerDefenceInstanceRewardRequest : IMessage<TowerDefenceInstanceRewardRequest>, IMessage, IEquatable<TowerDefenceInstanceRewardRequest>, IDeepCloneable<TowerDefenceInstanceRewardRequest>, IBufferMessage
	{
		// Token: 0x0601B53F RID: 111935 RVA: 0x003F977D File Offset: 0x003F797D
		[NullableContext(1)]
		public static TowerDefenceInstanceRewardRequest Create()
		{
			return new TowerDefenceInstanceRewardRequest();
		}

		// Token: 0x17005C83 RID: 23683
		// (get) Token: 0x0601B540 RID: 111936 RVA: 0x003F9784 File Offset: 0x003F7984
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C84 RID: 23684
		// (get) Token: 0x0601B541 RID: 111937 RVA: 0x003F9787 File Offset: 0x003F7987
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceInstanceRewardRequest.Descriptor;
			}
		}

		// Token: 0x0601B542 RID: 111938 RVA: 0x003F978E File Offset: 0x003F798E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardRequest()
		{
		}

		// Token: 0x0601B543 RID: 111939 RVA: 0x003F97A1 File Offset: 0x003F79A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardRequest(TowerDefenceInstanceRewardRequest other) : this()
		{
			this.ids_ = other.ids_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B544 RID: 111940 RVA: 0x003F97CB File Offset: 0x003F79CB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceRewardRequest Clone()
		{
			return new TowerDefenceInstanceRewardRequest(this);
		}

		// Token: 0x17005C85 RID: 23685
		// (get) Token: 0x0601B545 RID: 111941 RVA: 0x003F97D3 File Offset: 0x003F79D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<int> Ids
		{
			get
			{
				return this.ids_;
			}
		}

		// Token: 0x0601B546 RID: 111942 RVA: 0x003F97DB File Offset: 0x003F79DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceInstanceRewardRequest);
		}

		// Token: 0x0601B547 RID: 111943 RVA: 0x003F97E9 File Offset: 0x003F79E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceInstanceRewardRequest other)
		{
			return other != null && (other == this || (this.ids_.Equals(other.ids_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B548 RID: 111944 RVA: 0x003F981C File Offset: 0x003F7A1C
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

		// Token: 0x0601B549 RID: 111945 RVA: 0x003F9850 File Offset: 0x003F7A50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B54A RID: 111946 RVA: 0x003F985D File Offset: 0x003F7A5D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B54B RID: 111947 RVA: 0x003F9866 File Offset: 0x003F7A66
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

		// Token: 0x0601B54C RID: 111948 RVA: 0x003F9890 File Offset: 0x003F7A90
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

		// Token: 0x0601B54D RID: 111949 RVA: 0x003F98C9 File Offset: 0x003F7AC9
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

		// Token: 0x0601B54E RID: 111950 RVA: 0x003F98F7 File Offset: 0x003F7AF7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B54F RID: 111951 RVA: 0x003F9900 File Offset: 0x003F7B00
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
					this.ids_.AddEntriesFrom(ref input, TowerDefenceInstanceRewardRequest._repeated_ids_codec);
				}
			}
		}

		// Token: 0x04009F35 RID: 40757
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F36 RID: 40758
		public const int IdsFieldNumber = 11;

		// Token: 0x04009F37 RID: 40759
		private static readonly FieldCodec<int> _repeated_ids_codec = FieldCodec.ForInt32(90U);

		// Token: 0x04009F38 RID: 40760
		private readonly RepeatedField<int> ids_ = new RepeatedField<int>();
	}
}
