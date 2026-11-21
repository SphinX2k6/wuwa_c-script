using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076C0 RID: 30400
	public struct ISceneItemMoveMotionType : IFlatbufferObject
	{
		// Token: 0x1700DEF8 RID: 57080
		// (get) Token: 0x06035537 RID: 218423 RVA: 0x00727490 File Offset: 0x00725690
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06035538 RID: 218424 RVA: 0x0072749D File Offset: 0x0072569D
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06035539 RID: 218425 RVA: 0x007274A4 File Offset: 0x007256A4
		public static ISceneItemMoveMotionType GetRootAsISceneItemMoveMotionType(ByteBuffer _bb)
		{
			return ISceneItemMoveMotionType.GetRootAsISceneItemMoveMotionType(_bb, default(ISceneItemMoveMotionType));
		}

		// Token: 0x0603553A RID: 218426 RVA: 0x007274C0 File Offset: 0x007256C0
		public static ISceneItemMoveMotionType GetRootAsISceneItemMoveMotionType(ByteBuffer _bb, ISceneItemMoveMotionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603553B RID: 218427 RVA: 0x007274DD File Offset: 0x007256DD
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603553C RID: 218428 RVA: 0x007274EC File Offset: 0x007256EC
		public ISceneItemMoveMotionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEF9 RID: 57081
		// (get) Token: 0x0603553D RID: 218429 RVA: 0x007274FC File Offset: 0x007256FC
		public EMoveMotion Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EMoveMotion.UniformMotion;
				}
				return (EMoveMotion)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0603553E RID: 218430 RVA: 0x00727538 File Offset: 0x00725738
		public static Offset<ISceneItemMoveMotionType> CreateISceneItemMoveMotionType(FlatBufferBuilder builder, EMoveMotion Type = EMoveMotion.UniformMotion)
		{
			builder.StartTable(1);
			ISceneItemMoveMotionType.AddType(builder, Type);
			return ISceneItemMoveMotionType.EndISceneItemMoveMotionType(builder);
		}

		// Token: 0x0603553F RID: 218431 RVA: 0x0072754E File Offset: 0x0072574E
		public static void StartISceneItemMoveMotionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06035540 RID: 218432 RVA: 0x00727557 File Offset: 0x00725757
		public static void AddType(FlatBufferBuilder builder, EMoveMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06035541 RID: 218433 RVA: 0x00727562 File Offset: 0x00725762
		public static Offset<ISceneItemMoveMotionType> EndISceneItemMoveMotionType(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemMoveMotionType>(builder.EndTable());
		}

		// Token: 0x06035542 RID: 218434 RVA: 0x00727570 File Offset: 0x00725770
		public ISceneItemMoveMotionTypeT UnPack()
		{
			ISceneItemMoveMotionTypeT sceneItemMoveMotionTypeT = new ISceneItemMoveMotionTypeT();
			this.UnPackTo(sceneItemMoveMotionTypeT);
			return sceneItemMoveMotionTypeT;
		}

		// Token: 0x06035543 RID: 218435 RVA: 0x0072758B File Offset: 0x0072578B
		public void UnPackTo(ISceneItemMoveMotionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x06035544 RID: 218436 RVA: 0x0072759C File Offset: 0x0072579C
		public static Offset<ISceneItemMoveMotionType> Pack(FlatBufferBuilder builder, ISceneItemMoveMotionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemMoveMotionType>);
			}
			return ISceneItemMoveMotionType.CreateISceneItemMoveMotionType(builder, _o.Type);
		}

		// Token: 0x040128B3 RID: 75955
		private Table __p;
	}
}
