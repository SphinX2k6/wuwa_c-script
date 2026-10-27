using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F39 RID: 28473
	public struct ISceneItemMoveMotionType : IFlatbufferObject
	{
		// Token: 0x1700D39C RID: 54172
		// (get) Token: 0x060324DF RID: 206047 RVA: 0x006CB528 File Offset: 0x006C9728
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060324E0 RID: 206048 RVA: 0x006CB535 File Offset: 0x006C9735
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060324E1 RID: 206049 RVA: 0x006CB53C File Offset: 0x006C973C
		public static ISceneItemMoveMotionType GetRootAsISceneItemMoveMotionType(ByteBuffer _bb)
		{
			return ISceneItemMoveMotionType.GetRootAsISceneItemMoveMotionType(_bb, default(ISceneItemMoveMotionType));
		}

		// Token: 0x060324E2 RID: 206050 RVA: 0x006CB558 File Offset: 0x006C9758
		public static ISceneItemMoveMotionType GetRootAsISceneItemMoveMotionType(ByteBuffer _bb, ISceneItemMoveMotionType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060324E3 RID: 206051 RVA: 0x006CB575 File Offset: 0x006C9775
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060324E4 RID: 206052 RVA: 0x006CB584 File Offset: 0x006C9784
		public ISceneItemMoveMotionType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D39D RID: 54173
		// (get) Token: 0x060324E5 RID: 206053 RVA: 0x006CB594 File Offset: 0x006C9794
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

		// Token: 0x060324E6 RID: 206054 RVA: 0x006CB5D0 File Offset: 0x006C97D0
		public static Offset<ISceneItemMoveMotionType> CreateISceneItemMoveMotionType(FlatBufferBuilder builder, EMoveMotion Type = EMoveMotion.UniformMotion)
		{
			builder.StartTable(1);
			ISceneItemMoveMotionType.AddType(builder, Type);
			return ISceneItemMoveMotionType.EndISceneItemMoveMotionType(builder);
		}

		// Token: 0x060324E7 RID: 206055 RVA: 0x006CB5E6 File Offset: 0x006C97E6
		public static void StartISceneItemMoveMotionType(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x060324E8 RID: 206056 RVA: 0x006CB5EF File Offset: 0x006C97EF
		public static void AddType(FlatBufferBuilder builder, EMoveMotion type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x060324E9 RID: 206057 RVA: 0x006CB5FA File Offset: 0x006C97FA
		public static Offset<ISceneItemMoveMotionType> EndISceneItemMoveMotionType(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemMoveMotionType>(builder.EndTable());
		}

		// Token: 0x060324EA RID: 206058 RVA: 0x006CB608 File Offset: 0x006C9808
		public ISceneItemMoveMotionTypeT UnPack()
		{
			ISceneItemMoveMotionTypeT sceneItemMoveMotionTypeT = new ISceneItemMoveMotionTypeT();
			this.UnPackTo(sceneItemMoveMotionTypeT);
			return sceneItemMoveMotionTypeT;
		}

		// Token: 0x060324EB RID: 206059 RVA: 0x006CB623 File Offset: 0x006C9823
		public void UnPackTo(ISceneItemMoveMotionTypeT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x060324EC RID: 206060 RVA: 0x006CB634 File Offset: 0x006C9834
		public static Offset<ISceneItemMoveMotionType> Pack(FlatBufferBuilder builder, ISceneItemMoveMotionTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemMoveMotionType>);
			}
			return ISceneItemMoveMotionType.CreateISceneItemMoveMotionType(builder, _o.Type);
		}

		// Token: 0x0401192B RID: 71979
		private Table __p;
	}
}
