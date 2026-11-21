using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005C5D RID: 23645
	public struct IPartHitConfig : IFlatbufferObject
	{
		// Token: 0x1700ADCC RID: 44492
		// (get) Token: 0x06027393 RID: 160659 RVA: 0x0055F876 File Offset: 0x0055DA76
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06027394 RID: 160660 RVA: 0x0055F883 File Offset: 0x0055DA83
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06027395 RID: 160661 RVA: 0x0055F88C File Offset: 0x0055DA8C
		public static IPartHitConfig GetRootAsIPartHitConfig(ByteBuffer _bb)
		{
			return IPartHitConfig.GetRootAsIPartHitConfig(_bb, default(IPartHitConfig));
		}

		// Token: 0x06027396 RID: 160662 RVA: 0x0055F8A8 File Offset: 0x0055DAA8
		public static IPartHitConfig GetRootAsIPartHitConfig(ByteBuffer _bb, IPartHitConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06027397 RID: 160663 RVA: 0x0055F8C5 File Offset: 0x0055DAC5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06027398 RID: 160664 RVA: 0x0055F8D4 File Offset: 0x0055DAD4
		public IPartHitConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700ADCD RID: 44493
		// (get) Token: 0x06027399 RID: 160665 RVA: 0x0055F8E4 File Offset: 0x0055DAE4
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

		// Token: 0x0602739A RID: 160666 RVA: 0x0055F91B File Offset: 0x0055DB1B
		public Span<byte> GetPartNameBytes()
		{
			return this.__p.__vector_as_span<byte>(4, 1);
		}

		// Token: 0x0602739B RID: 160667 RVA: 0x0055F92A File Offset: 0x0055DB2A
		public byte[] GetPartNameArray()
		{
			return this.__p.__vector_as_array<byte>(4);
		}

		// Token: 0x1700ADCE RID: 44494
		// (get) Token: 0x0602739C RID: 160668 RVA: 0x0055F938 File Offset: 0x0055DB38
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

		// Token: 0x0602739D RID: 160669 RVA: 0x0055F974 File Offset: 0x0055DB74
		public TTable? HitBullets<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602739E RID: 160670 RVA: 0x0055F9B8 File Offset: 0x0055DBB8
		public IHitBulletTypeAllCharacterAttack HitBulletsAsIHitBulletTypeAllCharacterAttack()
		{
			return this.HitBullets<IHitBulletTypeAllCharacterAttack>().Value;
		}

		// Token: 0x0602739F RID: 160671 RVA: 0x0055F9D4 File Offset: 0x0055DBD4
		public IHitBulletTypeCrystalAttack HitBulletsAsIHitBulletTypeCrystalAttack()
		{
			return this.HitBullets<IHitBulletTypeCrystalAttack>().Value;
		}

		// Token: 0x060273A0 RID: 160672 RVA: 0x0055F9F0 File Offset: 0x0055DBF0
		public IHitBulletTypeFixedBulletId HitBulletsAsIHitBulletTypeFixedBulletId()
		{
			return this.HitBullets<IHitBulletTypeFixedBulletId>().Value;
		}

		// Token: 0x060273A1 RID: 160673 RVA: 0x0055FA0C File Offset: 0x0055DC0C
		public IHitBulletTypeOnlyDropAttack HitBulletsAsIHitBulletTypeOnlyDropAttack()
		{
			return this.HitBullets<IHitBulletTypeOnlyDropAttack>().Value;
		}

		// Token: 0x060273A2 RID: 160674 RVA: 0x0055FA28 File Offset: 0x0055DC28
		public IHitBulletTypePlayerAttack HitBulletsAsIHitBulletTypePlayerAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerAttack>().Value;
		}

		// Token: 0x060273A3 RID: 160675 RVA: 0x0055FA44 File Offset: 0x0055DC44
		public IHitBulletTypePlayerOrThrenodianAttack HitBulletsAsIHitBulletTypePlayerOrThrenodianAttack()
		{
			return this.HitBullets<IHitBulletTypePlayerOrThrenodianAttack>().Value;
		}

		// Token: 0x060273A4 RID: 160676 RVA: 0x0055FA60 File Offset: 0x0055DC60
		public IActionInfo? Actions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700ADCF RID: 44495
		// (get) Token: 0x060273A5 RID: 160677 RVA: 0x0055FAC4 File Offset: 0x0055DCC4
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

		// Token: 0x1700ADD0 RID: 44496
		// (get) Token: 0x060273A6 RID: 160678 RVA: 0x0055FAF0 File Offset: 0x0055DCF0
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

		// Token: 0x060273A7 RID: 160679 RVA: 0x0055FB2D File Offset: 0x0055DD2D
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

		// Token: 0x060273A8 RID: 160680 RVA: 0x0055FB61 File Offset: 0x0055DD61
		public static void StartIPartHitConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(5);
		}

		// Token: 0x060273A9 RID: 160681 RVA: 0x0055FB6A File Offset: 0x0055DD6A
		public static void AddPartName(FlatBufferBuilder builder, StringOffset partNameOffset)
		{
			builder.AddOffset(0, partNameOffset.Value, 0);
		}

		// Token: 0x060273AA RID: 160682 RVA: 0x0055FB7A File Offset: 0x0055DD7A
		public static void AddHitBulletsType(FlatBufferBuilder builder, THitBulletType hitBulletsType)
		{
			builder.AddByte(1, (byte)hitBulletsType, 0);
		}

		// Token: 0x060273AB RID: 160683 RVA: 0x0055FB85 File Offset: 0x0055DD85
		public static void AddHitBullets(FlatBufferBuilder builder, int hitBulletsOffset)
		{
			builder.AddOffset(2, hitBulletsOffset, 0);
		}

		// Token: 0x060273AC RID: 160684 RVA: 0x0055FB90 File Offset: 0x0055DD90
		public static void AddActions(FlatBufferBuilder builder, VectorOffset actionsOffset)
		{
			builder.AddOffset(3, actionsOffset.Value, 0);
		}

		// Token: 0x060273AD RID: 160685 RVA: 0x0055FBA0 File Offset: 0x0055DDA0
		public static VectorOffset CreateActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060273AE RID: 160686 RVA: 0x0055FBE0 File Offset: 0x0055DDE0
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060273AF RID: 160687 RVA: 0x0055FBFA File Offset: 0x0055DDFA
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060273B0 RID: 160688 RVA: 0x0055FC18 File Offset: 0x0055DE18
		public static VectorOffset CreateActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060273B1 RID: 160689 RVA: 0x0055FC31 File Offset: 0x0055DE31
		public static void StartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060273B2 RID: 160690 RVA: 0x0055FC3C File Offset: 0x0055DE3C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(4, nullMask, 0);
		}

		// Token: 0x060273B3 RID: 160691 RVA: 0x0055FC47 File Offset: 0x0055DE47
		public static Offset<IPartHitConfig> EndIPartHitConfig(FlatBufferBuilder builder)
		{
			return new Offset<IPartHitConfig>(builder.EndTable());
		}

		// Token: 0x060273B4 RID: 160692 RVA: 0x0055FC54 File Offset: 0x0055DE54
		public IPartHitConfigT UnPack()
		{
			IPartHitConfigT partHitConfigT = new IPartHitConfigT();
			this.UnPackTo(partHitConfigT);
			return partHitConfigT;
		}

		// Token: 0x060273B5 RID: 160693 RVA: 0x0055FC70 File Offset: 0x0055DE70
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

		// Token: 0x060273B6 RID: 160694 RVA: 0x0055FE90 File Offset: 0x0055E090
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

		// Token: 0x0400F75B RID: 63323
		private Table __p;
	}
}
