using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020012F3 RID: 4851
	[NetMessage(EMessageId.SurvivorsWeaponInfoResponse)]
	public sealed class SurvivorsWeaponInfoResponse : IMessage<SurvivorsWeaponInfoResponse>, IMessage, IEquatable<SurvivorsWeaponInfoResponse>, IDeepCloneable<SurvivorsWeaponInfoResponse>, IBufferMessage
	{
		// Token: 0x06019CB1 RID: 105649 RVA: 0x003BFA02 File Offset: 0x003BDC02
		[NullableContext(1)]
		public static SurvivorsWeaponInfoResponse Create()
		{
			return new SurvivorsWeaponInfoResponse();
		}

		// Token: 0x170056FE RID: 22270
		// (get) Token: 0x06019CB2 RID: 105650 RVA: 0x003BFA09 File Offset: 0x003BDC09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170056FF RID: 22271
		// (get) Token: 0x06019CB3 RID: 105651 RVA: 0x003BFA0C File Offset: 0x003BDC0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SurvivorsWeaponInfoResponse.Descriptor;
			}
		}

		// Token: 0x06019CB4 RID: 105652 RVA: 0x003BFA13 File Offset: 0x003BDC13
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoResponse()
		{
		}

		// Token: 0x06019CB5 RID: 105653 RVA: 0x003BFA26 File Offset: 0x003BDC26
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoResponse(SurvivorsWeaponInfoResponse other) : this()
		{
			this.weaponKillDict_ = other.weaponKillDict_.Clone();
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019CB6 RID: 105654 RVA: 0x003BFA50 File Offset: 0x003BDC50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SurvivorsWeaponInfoResponse Clone()
		{
			return new SurvivorsWeaponInfoResponse(this);
		}

		// Token: 0x17005700 RID: 22272
		// (get) Token: 0x06019CB7 RID: 105655 RVA: 0x003BFA58 File Offset: 0x003BDC58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapField<int, int> WeaponKillDict
		{
			get
			{
				return this.weaponKillDict_;
			}
		}

		// Token: 0x06019CB8 RID: 105656 RVA: 0x003BFA60 File Offset: 0x003BDC60
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SurvivorsWeaponInfoResponse);
		}

		// Token: 0x06019CB9 RID: 105657 RVA: 0x003BFA6E File Offset: 0x003BDC6E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SurvivorsWeaponInfoResponse other)
		{
			return other != null && (other == this || (this.WeaponKillDict.Equals(other.WeaponKillDict) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019CBA RID: 105658 RVA: 0x003BFAA4 File Offset: 0x003BDCA4
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

		// Token: 0x06019CBB RID: 105659 RVA: 0x003BFAD8 File Offset: 0x003BDCD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019CBC RID: 105660 RVA: 0x003BFAE5 File Offset: 0x003BDCE5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019CBD RID: 105661 RVA: 0x003BFAEE File Offset: 0x003BDCEE
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

		// Token: 0x06019CBE RID: 105662 RVA: 0x003BFB18 File Offset: 0x003BDD18
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

		// Token: 0x06019CBF RID: 105663 RVA: 0x003BFB51 File Offset: 0x003BDD51
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

		// Token: 0x06019CC0 RID: 105664 RVA: 0x003BFB7F File Offset: 0x003BDD7F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019CC1 RID: 105665 RVA: 0x003BFB88 File Offset: 0x003BDD88
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
				if (num != 58U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.weaponKillDict_.AddEntriesFrom(ref input, SurvivorsWeaponInfoResponse._map_weaponKillDict_codec);
				}
			}
		}

		// Token: 0x040096F3 RID: 38643
		private UnknownFieldSet _unknownFields;

		// Token: 0x040096F4 RID: 38644
		public const int WeaponKillDictFieldNumber = 7;

		// Token: 0x040096F5 RID: 38645
		private static readonly MapField<int, int>.Codec _map_weaponKillDict_codec = new MapField<int, int>.Codec(FieldCodec.ForInt32(8U, 0), FieldCodec.ForInt32(16U, 0), 58U);

		// Token: 0x040096F6 RID: 38646
		private readonly MapField<int, int> weaponKillDict_ = new MapField<int, int>();
	}
}
