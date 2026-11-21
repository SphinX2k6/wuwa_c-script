using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200141A RID: 5146
	[NetMessage(EMessageId.TowerDefencePhantomInfoUpdateNotify)]
	public sealed class TowerDefencePhantomInfoUpdateNotify : IMessage<TowerDefencePhantomInfoUpdateNotify>, IMessage, IEquatable<TowerDefencePhantomInfoUpdateNotify>, IDeepCloneable<TowerDefencePhantomInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B5AC RID: 112044 RVA: 0x003FA6E6 File Offset: 0x003F88E6
		[NullableContext(1)]
		public static TowerDefencePhantomInfoUpdateNotify Create()
		{
			return new TowerDefencePhantomInfoUpdateNotify();
		}

		// Token: 0x17005C9C RID: 23708
		// (get) Token: 0x0601B5AD RID: 112045 RVA: 0x003FA6ED File Offset: 0x003F88ED
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C9D RID: 23709
		// (get) Token: 0x0601B5AE RID: 112046 RVA: 0x003FA6F0 File Offset: 0x003F88F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefencePhantomInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B5AF RID: 112047 RVA: 0x003FA6F7 File Offset: 0x003F88F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfoUpdateNotify()
		{
		}

		// Token: 0x0601B5B0 RID: 112048 RVA: 0x003FA70A File Offset: 0x003F890A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfoUpdateNotify(TowerDefencePhantomInfoUpdateNotify other) : this()
		{
			this.phantoms_ = other.phantoms_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B5B1 RID: 112049 RVA: 0x003FA734 File Offset: 0x003F8934
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefencePhantomInfoUpdateNotify Clone()
		{
			return new TowerDefencePhantomInfoUpdateNotify(this);
		}

		// Token: 0x17005C9E RID: 23710
		// (get) Token: 0x0601B5B2 RID: 112050 RVA: 0x003FA73C File Offset: 0x003F893C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RepeatedField<TowerDefencePhantomInfo> Phantoms
		{
			get
			{
				return this.phantoms_;
			}
		}

		// Token: 0x0601B5B3 RID: 112051 RVA: 0x003FA744 File Offset: 0x003F8944
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefencePhantomInfoUpdateNotify);
		}

		// Token: 0x0601B5B4 RID: 112052 RVA: 0x003FA752 File Offset: 0x003F8952
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefencePhantomInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.phantoms_.Equals(other.phantoms_) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B5B5 RID: 112053 RVA: 0x003FA788 File Offset: 0x003F8988
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

		// Token: 0x0601B5B6 RID: 112054 RVA: 0x003FA7BC File Offset: 0x003F89BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B5B7 RID: 112055 RVA: 0x003FA7C9 File Offset: 0x003F89C9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B5B8 RID: 112056 RVA: 0x003FA7D2 File Offset: 0x003F89D2
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

		// Token: 0x0601B5B9 RID: 112057 RVA: 0x003FA7FC File Offset: 0x003F89FC
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

		// Token: 0x0601B5BA RID: 112058 RVA: 0x003FA835 File Offset: 0x003F8A35
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

		// Token: 0x0601B5BB RID: 112059 RVA: 0x003FA863 File Offset: 0x003F8A63
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B5BC RID: 112060 RVA: 0x003FA86C File Offset: 0x003F8A6C
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
				if (num != 66U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.phantoms_.AddEntriesFrom(ref input, TowerDefencePhantomInfoUpdateNotify._repeated_phantoms_codec);
				}
			}
		}

		// Token: 0x04009F59 RID: 40793
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F5A RID: 40794
		public const int PhantomsFieldNumber = 8;

		// Token: 0x04009F5B RID: 40795
		private static readonly FieldCodec<TowerDefencePhantomInfo> _repeated_phantoms_codec = FieldCodec.ForMessage<TowerDefencePhantomInfo>(66U, TowerDefencePhantomInfo.Parser);

		// Token: 0x04009F5C RID: 40796
		private readonly RepeatedField<TowerDefencePhantomInfo> phantoms_ = new RepeatedField<TowerDefencePhantomInfo>();
	}
}
