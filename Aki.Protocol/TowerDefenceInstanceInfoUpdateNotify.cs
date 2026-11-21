using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001414 RID: 5140
	[NetMessage(EMessageId.TowerDefenceInstanceInfoUpdateNotify)]
	public sealed class TowerDefenceInstanceInfoUpdateNotify : IMessage<TowerDefenceInstanceInfoUpdateNotify>, IMessage, IEquatable<TowerDefenceInstanceInfoUpdateNotify>, IDeepCloneable<TowerDefenceInstanceInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B52D RID: 111917 RVA: 0x003F959A File Offset: 0x003F779A
		[NullableContext(1)]
		public static TowerDefenceInstanceInfoUpdateNotify Create()
		{
			return new TowerDefenceInstanceInfoUpdateNotify();
		}

		// Token: 0x17005C80 RID: 23680
		// (get) Token: 0x0601B52E RID: 111918 RVA: 0x003F95A1 File Offset: 0x003F77A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C81 RID: 23681
		// (get) Token: 0x0601B52F RID: 111919 RVA: 0x003F95A4 File Offset: 0x003F77A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceInstanceInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B530 RID: 111920 RVA: 0x003F95AB File Offset: 0x003F77AB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfoUpdateNotify()
		{
		}

		// Token: 0x0601B531 RID: 111921 RVA: 0x003F95BE File Offset: 0x003F77BE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfoUpdateNotify(TowerDefenceInstanceInfoUpdateNotify other) : this()
		{
			this.instanceInfos_ = other.instanceInfos_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B532 RID: 111922 RVA: 0x003F95E8 File Offset: 0x003F77E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInstanceInfoUpdateNotify Clone()
		{
			return new TowerDefenceInstanceInfoUpdateNotify(this);
		}

		// Token: 0x17005C82 RID: 23682
		// (get) Token: 0x0601B533 RID: 111923 RVA: 0x003F95F0 File Offset: 0x003F77F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefenceInstanceInfo> InstanceInfos
		{
			get
			{
				return this.instanceInfos_;
			}
		}

		// Token: 0x0601B534 RID: 111924 RVA: 0x003F95F8 File Offset: 0x003F77F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceInstanceInfoUpdateNotify);
		}

		// Token: 0x0601B535 RID: 111925 RVA: 0x003F9606 File Offset: 0x003F7806
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceInstanceInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.instanceInfos_.Equals(other.instanceInfos_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B536 RID: 111926 RVA: 0x003F963C File Offset: 0x003F783C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.instanceInfos_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B537 RID: 111927 RVA: 0x003F9670 File Offset: 0x003F7870
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B538 RID: 111928 RVA: 0x003F967D File Offset: 0x003F787D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B539 RID: 111929 RVA: 0x003F9686 File Offset: 0x003F7886
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.instanceInfos_.WriteTo(ref output, TowerDefenceInstanceInfoUpdateNotify._repeated_instanceInfos_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B53A RID: 111930 RVA: 0x003F96B0 File Offset: 0x003F78B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.instanceInfos_.CalculateSize(TowerDefenceInstanceInfoUpdateNotify._repeated_instanceInfos_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B53B RID: 111931 RVA: 0x003F96E9 File Offset: 0x003F78E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceInstanceInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.instanceInfos_.Add(other.instanceInfos_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B53C RID: 111932 RVA: 0x003F9717 File Offset: 0x003F7917
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B53D RID: 111933 RVA: 0x003F9720 File Offset: 0x003F7920
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
				if (num != 82U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.instanceInfos_.AddEntriesFrom(ref input, TowerDefenceInstanceInfoUpdateNotify._repeated_instanceInfos_codec);
				}
			}
		}

		// Token: 0x04009F31 RID: 40753
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F32 RID: 40754
		public const int InstanceInfosFieldNumber = 10;

		// Token: 0x04009F33 RID: 40755
		private static readonly FieldCodec<TowerDefenceInstanceInfo> _repeated_instanceInfos_codec = FieldCodec.ForMessage<TowerDefenceInstanceInfo>(82U, TowerDefenceInstanceInfo.Parser);

		// Token: 0x04009F34 RID: 40756
		private readonly RepeatedField<TowerDefenceInstanceInfo> instanceInfos_ = new RepeatedField<TowerDefenceInstanceInfo>();
	}
}
