using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001362 RID: 4962
	[NetMessage(EMessageId.SurvivorsWeaponInfoResponse)]
	public sealed class SurvivorsWeaponInfoResponse : IMessage<SurvivorsWeaponInfoResponse>, IMessage, IEquatable<SurvivorsWeaponInfoResponse>, IDeepCloneable<SurvivorsWeaponInfoResponse>, IBufferMessage
	{
		// Token: 0x0601A6E7 RID: 108263 RVA: 0x003DA122 File Offset: 0x003D8322
		[NullableContext(1)]
		public static SurvivorsWeaponInfoResponse Create()
		{
			return new SurvivorsWeaponInfoResponse();
		}

		// Token: 0x1700597F RID: 22911
		// (get) Token: 0x0601A6E8 RID: 108264 RVA: 0x003DA129 File Offset: 0x003D8329
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005980 RID: 22912
		// (get) Token: 0x0601A6E9 RID: 108265 RVA: 0x003DA12C File Offset: 0x003D832C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeaponInfoResponse.Descriptor;
			}
		}

		// Token: 0x0601A6EA RID: 108266 RVA: 0x003DA133 File Offset: 0x003D8333
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoResponse()
		{
		}

		// Token: 0x0601A6EB RID: 108267 RVA: 0x003DA146 File Offset: 0x003D8346
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoResponse(SurvivorsWeaponInfoResponse other) : this()
		{
			this.weaponKillDict_ = other.weaponKillDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601A6EC RID: 108268 RVA: 0x003DA170 File Offset: 0x003D8370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoResponse Clone()
		{
			return new SurvivorsWeaponInfoResponse(this);
		}

		// Token: 0x17005981 RID: 22913
		// (get) Token: 0x0601A6ED RID: 108269 RVA: 0x003DA178 File Offset: 0x003D8378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> WeaponKillDict
		{
			get
			{
				return this.weaponKillDict_;
			}
		}

		// Token: 0x0601A6EE RID: 108270 RVA: 0x003DA180 File Offset: 0x003D8380
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeaponInfoResponse);
		}

		// Token: 0x0601A6EF RID: 108271 RVA: 0x003DA18E File Offset: 0x003D838E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeaponInfoResponse other)
		{
			return other != null && (other == this || (this.WeaponKillDict.Equals(other.WeaponKillDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601A6F0 RID: 108272 RVA: 0x003DA1C4 File Offset: 0x003D83C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			num ^= this.WeaponKillDict.GetHashCode();
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601A6F1 RID: 108273 RVA: 0x003DA1F8 File Offset: 0x003D83F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601A6F2 RID: 108274 RVA: 0x003DA205 File Offset: 0x003D8405
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601A6F3 RID: 108275 RVA: 0x003DA20E File Offset: 0x003D840E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			this.weaponKillDict_.WriteTo(ref output, SurvivorsWeaponInfoResponse._map_weaponKillDict_codec);
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601A6F4 RID: 108276 RVA: 0x003DA238 File Offset: 0x003D8438
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			num += this.weaponKillDict_.CalculateSize(SurvivorsWeaponInfoResponse._map_weaponKillDict_codec);
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601A6F5 RID: 108277 RVA: 0x003DA271 File Offset: 0x003D8471
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SurvivorsWeaponInfoResponse other)
		{
			if (other == null)
			{
				return;
			}
			this.weaponKillDict_.MergeFrom(other.weaponKillDict_);
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601A6F6 RID: 108278 RVA: 0x003DA29F File Offset: 0x003D849F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601A6F7 RID: 108279 RVA: 0x003DA2A8 File Offset: 0x003D84A8
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
				if (num != 122U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.weaponKillDict_.AddEntriesFrom(ref input, SurvivorsWeaponInfoResponse._map_weaponKillDict_codec);
				}
			}
		}

		// Token: 0x04009B1D RID: 39709
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009B1E RID: 39710
		public const int WeaponKillDictFieldNumber = 15;

		// Token: 0x04009B1F RID: 39711
		private static readonly MapField<int, int>.Codec _map_weaponKillDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 122U);

		// Token: 0x04009B20 RID: 39712
		private readonly MapField<int, int> weaponKillDict_ = new MapField<int, int>();
	}
}
