using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020056B9 RID: 22201
	public struct IPartHitConfig : IFlatbufferObject
	{
		// Token: 0x1700A538 RID: 42296
		// (get) Token: 0x0602513E RID: 151870 RVA: 0x0051E92E File Offset: 0x0051CB2E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602513F RID: 151871 RVA: 0x0051E93B File Offset: 0x0051CB3B
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06025140 RID: 151872 RVA: 0x0051E944 File Offset: 0x0051CB44
		public static IPartHitConfig GetRootAsIPartHitConfig(ByteBuffer _bb)
		{
			return IPartHitConfig.GetRootAsIPartHitConfig(_bb, default(IPartHitConfig));
		}

		// Token: 0x06025141 RID: 151873 RVA: 0x0051E960 File Offset: 0x0051CB60
		public static IPartHitConfig GetRootAsIPartHitConfig(ByteBuffer _bb, IPartHitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06025142 RID: 151874 RVA: 0x0051E97D File Offset: 0x0051CB7D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06025143 RID: 151875 RVA: 0x0051E98C File Offset: 0x0051CB8C
		public IPartHitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A539 RID: 42297
		// (get) Token: 0x06025144 RID: 151876 RVA: 0x0051E99C File Offset: 0x0051CB9C
		public string PartName
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return this.__p.__string(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025145 RID: 151877 RVA: 0x0051E9D3 File Offset: 0x0051CBD3
		public Span<byte> GetPartNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x06025146 RID: 151878 RVA: 0x0051E9E2 File Offset: 0x0051CBE2
		public byte[] GetPartNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700A53A RID: 42298
		// (get) Token: 0x06025147 RID: 151879 RVA: 0x0051E9F0 File Offset: 0x0051CBF0
		public THitBulletType HitBulletsType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return THitBulletType.NONE;
				}
				return (THitBulletType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025148 RID: 151880 RVA: 0x0051EA2C File Offset: 0x0051CC2C
		public TTable? HitBullets<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x06025149 RID: 151881 RVA: 0x0051EA70 File Offset: 0x0051CC70
		public IHitBulletTypeAllCharacterAttack HitBulletsAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullets<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x0602514A RID: 151882 RVA: 0x0051EA8C File Offset: 0x0051CC8C
		public IHitBulletTypeCrystalAttack HitBulletsAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullets<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x0602514B RID: 151883 RVA: 0x0051EAA8 File Offset: 0x0051CCA8
		public IHitBulletTypeFixedBulletId HitBulletsAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullets<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x0602514C RID: 151884 RVA: 0x0051EAC4 File Offset: 0x0051CCC4
		public IHitBulletTypeOnlyDropAttack HitBulletsAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullets<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x0602514D RID: 151885 RVA: 0x0051EAE0 File Offset: 0x0051CCE0
		public IHitBulletTypePlayerAttack HitBulletsAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x0602514E RID: 151886 RVA: 0x0051EAFC File Offset: 0x0051CCFC
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletsAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x0602514F RID: 151887 RVA: 0x0051EB18 File Offset: 0x0051CD18
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A53B RID: 42299
		// (get) Token: 0x06025150 RID: 151888 RVA: 0x0051EB7C File Offset: 0x0051CD7C
		public int ActionsLength
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700A53C RID: 42300
		// (get) Token: 0x06025151 RID: 151889 RVA: 0x0051EBA8 File Offset: 0x0051CDA8
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06025152 RID: 151890 RVA: 0x0051EBE5 File Offset: 0x0051CDE5
		public static Offset<IPartHitConfig> CreateIPartHitConfig(FlatBufferBuilder builder, StringOffset PartNameOffset = default(StringOffset), THitBulletType HitBullets_type = THitBulletType.NONE, int HitBulletsOffset = 0, VectorOffset ActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(5);
			IPartHitConfig.AddActions(builder, ActionsOffset);
			IPartHitConfig.AddHitBullets(builder, HitBulletsOffset);
			IPartHitConfig.AddPartName(builder, PartNameOffset);
			IPartHitConfig.AddNullMask(builder, NullMask);
			IPartHitConfig.AddHitBulletsType(builder, HitBullets_type);
			return IPartHitConfig.EndIPartHitConfig(builder);
		}

		// Token: 0x06025153 RID: 151891 RVA: 0x0051EC19 File Offset: 0x0051CE19
		public static void StartIPartHitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x06025154 RID: 151892 RVA: 0x0051EC22 File Offset: 0x0051CE22
		public static void AddPartName(FlatBufferBuilder builder, StringOffset partNameOffset)
		{
			builder.AddOffset(0, partNameOffset.Value, 0);
		}

		// Token: 0x06025155 RID: 151893 RVA: 0x0051EC32 File Offset: 0x0051CE32
		public static void AddHitBulletsType(FlatBufferBuilder builder, THitBulletType hitBulletsType)
		{
			builder.AddByte(1, (byte)hitBulletsType, 0);
		}

		// Token: 0x06025156 RID: 151894 RVA: 0x0051EC3D File Offset: 0x0051CE3D
		public static void AddHitBullets(FlatBufferBuilder builder, int hitBulletsOffset)
		{
			builder.AddOffset(2, hitBulletsOffset, 0);
		}

		// Token: 0x06025157 RID: 151895 RVA: 0x0051EC48 File Offset: 0x0051CE48
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(3, actionsOffset.Value, 0);
		}

		// Token: 0x06025158 RID: 151896 RVA: 0x0051EC58 File Offset: 0x0051CE58
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06025159 RID: 151897 RVA: 0x0051EC98 File Offset: 0x0051CE98
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602515A RID: 151898 RVA: 0x0051ECB2 File Offset: 0x0051CEB2
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602515B RID: 151899 RVA: 0x0051ECD0 File Offset: 0x0051CED0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602515C RID: 151900 RVA: 0x0051ECE9 File Offset: 0x0051CEE9
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602515D RID: 151901 RVA: 0x0051ECF4 File Offset: 0x0051CEF4
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x0602515E RID: 151902 RVA: 0x0051ECFF File Offset: 0x0051CEFF
		public static Offset<IPartHitConfig> EndIPartHitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPartHitConfig>(builder.EndTable());
		}

		// Token: 0x0602515F RID: 151903 RVA: 0x0051ED0C File Offset: 0x0051CF0C
		public IPartHitConfigT UnPack()
		{
			IPartHitConfigT partHitConfigT = new IPartHitConfigT();
			this.UnPackTo(partHitConfigT);
			return partHitConfigT;
		}

		// Token: 0x06025160 RID: 151904 RVA: 0x0051ED28 File Offset: 0x0051CF28
		public void UnPackTo(IPartHitConfigT _o)
		{
			_o.PartName = this.PartName;
			_o.HitBullets = new THitBulletTypeUnion();
			_o.HitBullets.Type = this.HitBulletsType;
			switch (this.HitBulletsType)
			{
			case THitBulletType.IHitBulletTypeAllCharacterAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeAllCharacterAttack>() != null) ? this.HitBullets<IHitBulletTypeAllCharacterAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeCrystalAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeCrystalAttack>() != null) ? this.HitBullets<IHitBulletTypeCrystalAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeFixedBulletId:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeFixedBulletId>() != null) ? this.HitBullets<IHitBulletTypeFixedBulletId>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypeOnlyDropAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypeOnlyDropAttack>() != null) ? this.HitBullets<IHitBulletTypeOnlyDropAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypePlayerAttack>() != null) ? this.HitBullets<IHitBulletTypePlayerAttack>().Value.UnPack() : null);
				break;
			case THitBulletType.IHitBulletTypePlayerOrThrenodianAttack:
				_o.HitBullets.Value = ((this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>() != null) ? this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>().Value.UnPack() : null);
				break;
			}
			_o.Actions = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionsLength; i++)
			{
				_o.Actions.Add((this.Actions(i) != null) ? this.Actions(i).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x06025161 RID: 151905 RVA: 0x0051EF48 File Offset: 0x0051D148
		public static Offset<IPartHitConfig> Pack(FlatBufferBuilder builder, IPartHitConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<IPartHitConfig>);
			}
			StringOffset partNameOffset = (_o.PartName == null) ? default(StringOffset) : builder.CreateString(_o.PartName);
			THitBulletType hitBullets_type = (_o.HitBullets == null) ? THitBulletType.NONE : _o.HitBullets.Type;
			int hitBulletsOffset = (_o.HitBullets == null) ? 0 : THitBulletTypeUnion.Pack(builder, _o.HitBullets);
			VectorOffset actionsOffset = default(VectorOffset);
			if (_o.Actions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.Actions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.Actions[i]);
				}
				actionsOffset = IPartHitConfig.CreateActionsVector(builder, array);
			}
			return IPartHitConfig.CreateIPartHitConfig(builder, partNameOffset, hitBullets_type, hitBulletsOffset, actionsOffset, _o.NullMask);
		}

		// Token: 0x0400EAEF RID: 60143
		private Table __p;
	}
}
