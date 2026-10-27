using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020058C4 RID: 22724
	public struct ISceneItemInhalation : IFlatbufferObject
	{
		// Token: 0x1700AA26 RID: 43558
		// (get) Token: 0x06026590 RID: 157072 RVA: 0x00548F83 File Offset: 0x00547183
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06026591 RID: 157073 RVA: 0x00548F90 File Offset: 0x00547190
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06026592 RID: 157074 RVA: 0x00548F98 File Offset: 0x00547198
		public static ISceneItemInhalation GetRootAsISceneItemInhalation(ByteBuffer _bb)
		{
			return ISceneItemInhalation.GetRootAsISceneItemInhalation(_bb, default(ISceneItemInhalation));
		}

		// Token: 0x06026593 RID: 157075 RVA: 0x00548FB4 File Offset: 0x005471B4
		public static ISceneItemInhalation GetRootAsISceneItemInhalation(ByteBuffer _bb, ISceneItemInhalation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06026594 RID: 157076 RVA: 0x00548FD1 File Offset: 0x005471D1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06026595 RID: 157077 RVA: 0x00548FE0 File Offset: 0x005471E0
		public ISceneItemInhalation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700AA27 RID: 43559
		// (get) Token: 0x06026596 RID: 157078 RVA: 0x00548FF0 File Offset: 0x005471F0
		public EInhalationPerformanceType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EInhalationPerformanceType.Role;
				}
				return (EInhalationPerformanceType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06026597 RID: 157079 RVA: 0x0054902C File Offset: 0x0054722C
		public static Offset<ISceneItemInhalation> CreateISceneItemInhalation(FlatBufferBuilder builder, EInhalationPerformanceType Type = EInhalationPerformanceType.Role)
		{
			builder.StartTable(1);
			ISceneItemInhalation.AddType(builder, Type);
			return ISceneItemInhalation.EndISceneItemInhalation(builder);
		}

		// Token: 0x06026598 RID: 157080 RVA: 0x00549042 File Offset: 0x00547242
		public static void StartISceneItemInhalation(FlatBufferBuilder builder)
		{
			builder.StartTable(1);
		}

		// Token: 0x06026599 RID: 157081 RVA: 0x0054904B File Offset: 0x0054724B
		public static void AddType(FlatBufferBuilder builder, EInhalationPerformanceType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602659A RID: 157082 RVA: 0x00549056 File Offset: 0x00547256
		public static Offset<ISceneItemInhalation> EndISceneItemInhalation(FlatBufferBuilder builder)
		{
			return new Offset<ISceneItemInhalation>(builder.EndTable());
		}

		// Token: 0x0602659B RID: 157083 RVA: 0x00549064 File Offset: 0x00547264
		public ISceneItemInhalationT UnPack()
		{
			ISceneItemInhalationT sceneItemInhalationT = new ISceneItemInhalationT();
			this.UnPackTo(sceneItemInhalationT);
			return sceneItemInhalationT;
		}

		// Token: 0x0602659C RID: 157084 RVA: 0x0054907F File Offset: 0x0054727F
		public void UnPackTo(ISceneItemInhalationT _o)
		{
			_o.Type = this.Type;
		}

		// Token: 0x0602659D RID: 157085 RVA: 0x00549090 File Offset: 0x00547290
		public static Offset<ISceneItemInhalation> Pack(FlatBufferBuilder builder, ISceneItemInhalationT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneItemInhalation>);
			}
			return ISceneItemInhalation.CreateISceneItemInhalation(builder, _o.Type);
		}

		// Token: 0x0400EE3B RID: 60987
		private Table __p;
	}
}
