using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020076B7 RID: 30391
	public struct ISceneInspectionPoint : IFlatbufferObject
	{
		// Token: 0x1700DEEE RID: 57070
		// (get) Token: 0x060354FB RID: 218363 RVA: 0x00726D97 File Offset: 0x00724F97
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060354FC RID: 218364 RVA: 0x00726DA4 File Offset: 0x00724FA4
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060354FD RID: 218365 RVA: 0x00726DAC File Offset: 0x00724FAC
		public static ISceneInspectionPoint GetRootAsISceneInspectionPoint(ByteBuffer _bb)
		{
			return ISceneInspectionPoint.GetRootAsISceneInspectionPoint(_bb, default(ISceneInspectionPoint));
		}

		// Token: 0x060354FE RID: 218366 RVA: 0x00726DC8 File Offset: 0x00724FC8
		public static ISceneInspectionPoint GetRootAsISceneInspectionPoint(ByteBuffer _bb, ISceneInspectionPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060354FF RID: 218367 RVA: 0x00726DE5 File Offset: 0x00724FE5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06035500 RID: 218368 RVA: 0x00726DF4 File Offset: 0x00724FF4
		public ISceneInspectionPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700DEEF RID: 57071
		// (get) Token: 0x06035501 RID: 218369 RVA: 0x00726E04 File Offset: 0x00725004
		public IVectorInfo? InteractPointPos
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new IVectorInfo?(default(IVectorInfo).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06035502 RID: 218370 RVA: 0x00726E64 File Offset: 0x00725064
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700DEF0 RID: 57072
		// (get) Token: 0x06035503 RID: 218371 RVA: 0x00726EC4 File Offset: 0x007250C4
		public int ActionListLength
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x06035504 RID: 218372 RVA: 0x00726EEF File Offset: 0x007250EF
		public static Offset<ISceneInspectionPoint> CreateISceneInspectionPoint(FlatBufferBuilder builder, Offset<IVectorInfo> InteractPointPosOffset = default(Offset<IVectorInfo>), VectorOffset ActionListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISceneInspectionPoint.AddActionList(builder, ActionListOffset);
			ISceneInspectionPoint.AddInteractPointPos(builder, InteractPointPosOffset);
			return ISceneInspectionPoint.EndISceneInspectionPoint(builder);
		}

		// Token: 0x06035505 RID: 218373 RVA: 0x00726F0C File Offset: 0x0072510C
		public static void StartISceneInspectionPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06035506 RID: 218374 RVA: 0x00726F15 File Offset: 0x00725115
		public static void AddInteractPointPos(FlatBufferBuilder builder, Offset<IVectorInfo> interactPointPosOffset)
		{
			builder.AddOffset(0, interactPointPosOffset.Value, 0);
		}

		// Token: 0x06035507 RID: 218375 RVA: 0x00726F25 File Offset: 0x00725125
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(1, actionListOffset.Value, 0);
		}

		// Token: 0x06035508 RID: 218376 RVA: 0x00726F38 File Offset: 0x00725138
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06035509 RID: 218377 RVA: 0x00726F78 File Offset: 0x00725178
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603550A RID: 218378 RVA: 0x00726F92 File Offset: 0x00725192
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0603550B RID: 218379 RVA: 0x00726FB0 File Offset: 0x007251B0
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603550C RID: 218380 RVA: 0x00726FC9 File Offset: 0x007251C9
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603550D RID: 218381 RVA: 0x00726FD4 File Offset: 0x007251D4
		public static Offset<ISceneInspectionPoint> EndISceneInspectionPoint(FlatBufferBuilder builder)
		{
			return new Offset<ISceneInspectionPoint>(builder.EndTable());
		}

		// Token: 0x0603550E RID: 218382 RVA: 0x00726FE4 File Offset: 0x007251E4
		public ISceneInspectionPointT UnPack()
		{
			ISceneInspectionPointT sceneInspectionPointT = new ISceneInspectionPointT();
			this.UnPackTo(sceneInspectionPointT);
			return sceneInspectionPointT;
		}

		// Token: 0x0603550F RID: 218383 RVA: 0x00727000 File Offset: 0x00725200
		public void UnPackTo(ISceneInspectionPointT _o)
		{
			_o.InteractPointPos = ((this.InteractPointPos != null) ? this.InteractPointPos.Value.UnPack() : null);
			_o.ActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionListLength; i++)
			{
				_o.ActionList.Add((this.ActionList(i) != null) ? this.ActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x06035510 RID: 218384 RVA: 0x00727090 File Offset: 0x00725290
		public static Offset<ISceneInspectionPoint> Pack(FlatBufferBuilder builder, ISceneInspectionPointT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISceneInspectionPoint>);
			}
			Offset<IVectorInfo> interactPointPosOffset = (_o.InteractPointPos == null) ? default(Offset<IVectorInfo>) : IVectorInfo.Pack(builder, _o.InteractPointPos);
			VectorOffset actionListOffset = default(VectorOffset);
			if (_o.ActionList != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.ActionList.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.ActionList[i]);
				}
				actionListOffset = ISceneInspectionPoint.CreateActionListVector(builder, array);
			}
			return ISceneInspectionPoint.CreateISceneInspectionPoint(builder, interactPointPosOffset, actionListOffset);
		}

		// Token: 0x040128A7 RID: 75943
		private Table __p;
	}
}
