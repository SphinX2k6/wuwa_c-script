using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013A7 RID: 5031
	[NetMessage(EMessageId.TowerDefencePhantomInfoUpdateNotify)]
	public sealed class TowerDefencePhantomInfoUpdateNotify : IMessage<TowerDefencePhantomInfoUpdateNotify>, IMessage, IEquatable<TowerDefencePhantomInfoUpdateNotify>, IDeepCloneable<TowerDefencePhantomInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601AB21 RID: 109345 RVA: 0x003DF426 File Offset: 0x003DD626
		[NullableContext(1)]
		public static TowerDefencePhantomInfoUpdateNotify Create()
		{
			return new TowerDefencePhantomInfoUpdateNotify();
		}

		// Token: 0x17005A07 RID: 23047
		// (get) Token: 0x0601AB22 RID: 109346 RVA: 0x003DF42D File Offset: 0x003DD62D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005A08 RID: 23048
		// (get) Token: 0x0601AB23 RID: 109347 RVA: 0x003DF430 File Offset: 0x003DD630
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefencePhantomInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601AB24 RID: 109348 RVA: 0x003DF437 File Offset: 0x003DD637
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfoUpdateNotify()
		{
		}

		// Token: 0x0601AB25 RID: 109349 RVA: 0x003DF44A File Offset: 0x003DD64A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfoUpdateNotify(TowerDefencePhantomInfoUpdateNotify other) : this()
		{
			this.phantoms_ = other.phantoms_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AB26 RID: 109350 RVA: 0x003DF474 File Offset: 0x003DD674
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfoUpdateNotify Clone()
		{
			return new TowerDefencePhantomInfoUpdateNotify(this);
		}

		// Token: 0x17005A09 RID: 23049
		// (get) Token: 0x0601AB27 RID: 109351 RVA: 0x003DF47C File Offset: 0x003DD67C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefencePhantomInfo> Phantoms
		{
			get
			{
				return this.phantoms_;
			}
		}

		// Token: 0x0601AB28 RID: 109352 RVA: 0x003DF484 File Offset: 0x003DD684
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefencePhantomInfoUpdateNotify);
		}

		// Token: 0x0601AB29 RID: 109353 RVA: 0x003DF492 File Offset: 0x003DD692
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefencePhantomInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantoms_.Equals(other.phantoms_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AB2A RID: 109354 RVA: 0x003DF4C8 File Offset: 0x003DD6C8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.phantoms_.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AB2B RID: 109355 RVA: 0x003DF4FC File Offset: 0x003DD6FC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AB2C RID: 109356 RVA: 0x003DF509 File Offset: 0x003DD709
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AB2D RID: 109357 RVA: 0x003DF512 File Offset: 0x003DD712
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.phantoms_.WriteTo(ref output, TowerDefencePhantomInfoUpdateNotify._repeated_phantoms_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AB2E RID: 109358 RVA: 0x003DF53C File Offset: 0x003DD73C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.phantoms_.CalculateSize(TowerDefencePhantomInfoUpdateNotify._repeated_phantoms_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AB2F RID: 109359 RVA: 0x003DF575 File Offset: 0x003DD775
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefencePhantomInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			this.phantoms_.Add(other.phantoms_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AB30 RID: 109360 RVA: 0x003DF5A3 File Offset: 0x003DD7A3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AB31 RID: 109361 RVA: 0x003DF5AC File Offset: 0x003DD7AC
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
					this.phantoms_.AddEntriesFrom(ref input, TowerDefencePhantomInfoUpdateNotify._repeated_phantoms_codec);
				}
			}
		}

		// Token: 0x04009B12 RID: 39698
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B13 RID: 39699
		public const int PhantomsFieldNumber = 10;

		// Token: 0x04009B14 RID: 39700
		private static readonly FieldCodec<TowerDefencePhantomInfo> _repeated_phantoms_codec = FieldCodec.ForMessage<TowerDefencePhantomInfo>(82U, TowerDefencePhantomInfo.Parser);

		// Token: 0x04009B15 RID: 39701
		private readonly RepeatedField<TowerDefencePhantomInfo> phantoms_ = new RepeatedField<TowerDefencePhantomInfo>();
	}
}
