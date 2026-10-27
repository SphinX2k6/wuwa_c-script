using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006AB2 RID: 27314
	public struct IModifyActorMaterialParamBySplineProgressEnterSpline : IFlatbufferObject
	{
		// Token: 0x1700CAAC RID: 51884
		// (get) Token: 0x0602FDD0 RID: 196048 RVA: 0x00682D7C File Offset: 0x00680F7C
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602FDD1 RID: 196049 RVA: 0x00682D89 File Offset: 0x00680F89
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602FDD2 RID: 196050 RVA: 0x00682D90 File Offset: 0x00680F90
		public static IModifyActorMaterialParamBySplineProgressEnterSpline GetRootAsIModifyActorMaterialParamBySplineProgressEnterSpline(ByteBuffer _bb)
		{
			return IModifyActorMaterialParamBySplineProgressEnterSpline.GetRootAsIModifyActorMaterialParamBySplineProgressEnterSpline(_bb, default(IModifyActorMaterialParamBySplineProgressEnterSpline));
		}

		// Token: 0x0602FDD3 RID: 196051 RVA: 0x00682DAC File Offset: 0x00680FAC
		public static IModifyActorMaterialParamBySplineProgressEnterSpline GetRootAsIModifyActorMaterialParamBySplineProgressEnterSpline(ByteBuffer _bb, IModifyActorMaterialParamBySplineProgressEnterSpline obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602FDD4 RID: 196052 RVA: 0x00682DC9 File Offset: 0x00680FC9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602FDD5 RID: 196053 RVA: 0x00682DD8 File Offset: 0x00680FD8
		public IModifyActorMaterialParamBySplineProgressEnterSpline __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CAAD RID: 51885
		// (get) Token: 0x0602FDD6 RID: 196054 RVA: 0x00682DE8 File Offset: 0x00680FE8
		public EModifyActorMaterialParamBySplineProgressType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EModifyActorMaterialParamBySplineProgressType.EnterSpline;
				}
				return (EModifyActorMaterialParamBySplineProgressType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700CAAE RID: 51886
		// (get) Token: 0x0602FDD7 RID: 196055 RVA: 0x00682E24 File Offset: 0x00681024
		public int SplineEntityId
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602FDD8 RID: 196056 RVA: 0x00682E60 File Offset: 0x00681060
		public IActorRefWithMaterialParam? ActorRefs(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActorRefWithMaterialParam?(default(IActorRefWithMaterialParam).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CAAF RID: 51887
		// (get) Token: 0x0602FDD9 RID: 196057 RVA: 0x00682EC0 File Offset: 0x006810C0
		public int ActorRefsLength
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602FDDA RID: 196058 RVA: 0x00682EEB File Offset: 0x006810EB
		public static Offset<IModifyActorMaterialParamBySplineProgressEnterSpline> CreateIModifyActorMaterialParamBySplineProgressEnterSpline(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType Type = EModifyActorMaterialParamBySplineProgressType.EnterSpline, int SplineEntityId = 0, VectorOffset ActorRefsOffset = default(VectorOffset))
		{
			builder.StartTable(3);
			IModifyActorMaterialParamBySplineProgressEnterSpline.AddActorRefs(builder, ActorRefsOffset);
			IModifyActorMaterialParamBySplineProgressEnterSpline.AddSplineEntityId(builder, SplineEntityId);
			IModifyActorMaterialParamBySplineProgressEnterSpline.AddType(builder, Type);
			return IModifyActorMaterialParamBySplineProgressEnterSpline.EndIModifyActorMaterialParamBySplineProgressEnterSpline(builder);
		}

		// Token: 0x0602FDDB RID: 196059 RVA: 0x00682F0F File Offset: 0x0068110F
		public static void StartIModifyActorMaterialParamBySplineProgressEnterSpline(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x0602FDDC RID: 196060 RVA: 0x00682F18 File Offset: 0x00681118
		public static void AddType(FlatBufferBuilder builder, EModifyActorMaterialParamBySplineProgressType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602FDDD RID: 196061 RVA: 0x00682F23 File Offset: 0x00681123
		public static void AddSplineEntityId(FlatBufferBuilder builder, int splineEntityId)
		{
			builder.AddInt(1, splineEntityId, 0);
		}

		// Token: 0x0602FDDE RID: 196062 RVA: 0x00682F2E File Offset: 0x0068112E
		public static void AddActorRefs(FlatBufferBuilder builder, VectorOffset actorRefsOffset)
		{
			builder.AddOffset(2, actorRefsOffset.Value, 0);
		}

		// Token: 0x0602FDDF RID: 196063 RVA: 0x00682F40 File Offset: 0x00681140
		public static VectorOffset CreateActorRefsVector(FlatBufferBuilder builder, Offset<IActorRefWithMaterialParam>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602FDE0 RID: 196064 RVA: 0x00682F80 File Offset: 0x00681180
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, Offset<IActorRefWithMaterialParam>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActorRefWithMaterialParam>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FDE1 RID: 196065 RVA: 0x00682F9A File Offset: 0x0068119A
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActorRefWithMaterialParam>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActorRefWithMaterialParam>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602FDE2 RID: 196066 RVA: 0x00682FB8 File Offset: 0x006811B8
		public static VectorOffset CreateActorRefsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActorRefWithMaterialParam>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602FDE3 RID: 196067 RVA: 0x00682FD1 File Offset: 0x006811D1
		public static void StartActorRefsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602FDE4 RID: 196068 RVA: 0x00682FDC File Offset: 0x006811DC
		public static Offset<IModifyActorMaterialParamBySplineProgressEnterSpline> EndIModifyActorMaterialParamBySplineProgressEnterSpline(FlatBufferBuilder builder)
		{
			return new Offset<IModifyActorMaterialParamBySplineProgressEnterSpline>(builder.EndTable());
		}

		// Token: 0x0602FDE5 RID: 196069 RVA: 0x00682FEC File Offset: 0x006811EC
		public IModifyActorMaterialParamBySplineProgressEnterSplineT UnPack()
		{
			IModifyActorMaterialParamBySplineProgressEnterSplineT modifyActorMaterialParamBySplineProgressEnterSplineT = new IModifyActorMaterialParamBySplineProgressEnterSplineT();
			this.UnPackTo(modifyActorMaterialParamBySplineProgressEnterSplineT);
			return modifyActorMaterialParamBySplineProgressEnterSplineT;
		}

		// Token: 0x0602FDE6 RID: 196070 RVA: 0x00683008 File Offset: 0x00681208
		public void UnPackTo(IModifyActorMaterialParamBySplineProgressEnterSplineT _o)
		{
			_o.Type = this.Type;
			_o.SplineEntityId = this.SplineEntityId;
			_o.ActorRefs = new List<IActorRefWithMaterialParamT>();
			for (int i = 0; i < this.ActorRefsLength; i++)
			{
				_o.ActorRefs.Add((this.ActorRefs(i) != null) ? this.ActorRefs(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0602FDE7 RID: 196071 RVA: 0x00683080 File Offset: 0x00681280
		public static Offset<IModifyActorMaterialParamBySplineProgressEnterSpline> Pack(FlatBufferBuilder builder, IModifyActorMaterialParamBySplineProgressEnterSplineT _o)
		{
			if (_o == null)
			{
				return default(Offset<IModifyActorMaterialParamBySplineProgressEnterSpline>);
			}
			VectorOffset actorRefsOffset = default(VectorOffset);
			if (_o.ActorRefs != null)
			{
				Offset<IActorRefWithMaterialParam>[] array = new Offset<IActorRefWithMaterialParam>[_o.ActorRefs.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActorRefWithMaterialParam.Pack(builder, _o.ActorRefs[i]);
				}
				actorRefsOffset = IModifyActorMaterialParamBySplineProgressEnterSpline.CreateActorRefsVector(builder, array);
			}
			return IModifyActorMaterialParamBySplineProgressEnterSpline.CreateIModifyActorMaterialParamBySplineProgressEnterSpline(builder, _o.Type, _o.SplineEntityId, actorRefsOffset);
		}

		// Token: 0x040112F1 RID: 70385
		private Table __p;
	}
}
