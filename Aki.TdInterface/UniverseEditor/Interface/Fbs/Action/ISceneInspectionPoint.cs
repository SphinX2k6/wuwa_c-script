using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Var;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006F30 RID: 28464
	public struct ISceneInspectionPoint : IFlatbufferObject
	{
		// Token: 0x1700D392 RID: 54162
		// (get) Token: 0x060324A3 RID: 205987 RVA: 0x006CAE2F File Offset: 0x006C902F
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060324A4 RID: 205988 RVA: 0x006CAE3C File Offset: 0x006C903C
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060324A5 RID: 205989 RVA: 0x006CAE44 File Offset: 0x006C9044
		public static ISceneInspectionPoint GetRootAsISceneInspectionPoint(ByteBuffer _bb)
		{
			return ISceneInspectionPoint.GetRootAsISceneInspectionPoint(_bb, default(ISceneInspectionPoint));
		}

		// Token: 0x060324A6 RID: 205990 RVA: 0x006CAE60 File Offset: 0x006C9060
		public static ISceneInspectionPoint GetRootAsISceneInspectionPoint(ByteBuffer _bb, ISceneInspectionPoint obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060324A7 RID: 205991 RVA: 0x006CAE7D File Offset: 0x006C907D
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060324A8 RID: 205992 RVA: 0x006CAE8C File Offset: 0x006C908C
		public ISceneInspectionPoint __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D393 RID: 54163
		// (get) Token: 0x060324A9 RID: 205993 RVA: 0x006CAE9C File Offset: 0x006C909C
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

		// Token: 0x060324AA RID: 205994 RVA: 0x006CAEFC File Offset: 0x006C90FC
		public IActionInfo? ActionList(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700D394 RID: 54164
		// (get) Token: 0x060324AB RID: 205995 RVA: 0x006CAF5C File Offset: 0x006C915C
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

		// Token: 0x060324AC RID: 205996 RVA: 0x006CAF87 File Offset: 0x006C9187
		public static Offset<ISceneInspectionPoint> CreateISceneInspectionPoint(FlatBufferBuilder builder, Offset<IVectorInfo> InteractPointPosOffset = default(Offset<IVectorInfo>), VectorOffset ActionListOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			ISceneInspectionPoint.AddActionList(builder, ActionListOffset);
			ISceneInspectionPoint.AddInteractPointPos(builder, InteractPointPosOffset);
			return ISceneInspectionPoint.EndISceneInspectionPoint(builder);
		}

		// Token: 0x060324AD RID: 205997 RVA: 0x006CAFA4 File Offset: 0x006C91A4
		public static void StartISceneInspectionPoint(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x060324AE RID: 205998 RVA: 0x006CAFAD File Offset: 0x006C91AD
		public static void AddInteractPointPos(FlatBufferBuilder builder, Offset<IVectorInfo> interactPointPosOffset)
		{
			builder.AddOffset(0, interactPointPosOffset.Value, 0);
		}

		// Token: 0x060324AF RID: 205999 RVA: 0x006CAFBD File Offset: 0x006C91BD
		public static void AddActionList(FlatBufferBuilder builder, VectorOffset actionListOffset)
		{
			builder.AddOffset(1, actionListOffset.Value, 0);
		}

		// Token: 0x060324B0 RID: 206000 RVA: 0x006CAFD0 File Offset: 0x006C91D0
		public static VectorOffset CreateActionListVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x060324B1 RID: 206001 RVA: 0x006CB010 File Offset: 0x006C9210
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060324B2 RID: 206002 RVA: 0x006CB02A File Offset: 0x006C922A
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x060324B3 RID: 206003 RVA: 0x006CB048 File Offset: 0x006C9248
		public static VectorOffset CreateActionListVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x060324B4 RID: 206004 RVA: 0x006CB061 File Offset: 0x006C9261
		public static void StartActionListVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x060324B5 RID: 206005 RVA: 0x006CB06C File Offset: 0x006C926C
		public static Offset<ISceneInspectionPoint> EndISceneInspectionPoint(FlatBufferBuilder builder)
		{
			return new Offset<ISceneInspectionPoint>(builder.EndTable());
		}

		// Token: 0x060324B6 RID: 206006 RVA: 0x006CB07C File Offset: 0x006C927C
		public ISceneInspectionPointT UnPack()
		{
			ISceneInspectionPointT sceneInspectionPointT = new ISceneInspectionPointT();
			this.UnPackTo(sceneInspectionPointT);
			return sceneInspectionPointT;
		}

		// Token: 0x060324B7 RID: 206007 RVA: 0x006CB098 File Offset: 0x006C9298
		public void UnPackTo(ISceneInspectionPointT _o)
		{
			_o.InteractPointPos = ((this.InteractPointPos != null) ? this.InteractPointPos.Value.UnPack() : null);
			_o.ActionList = new List<IActionInfoT>();
			for (int i = 0; i < this.ActionListLength; i++)
			{
				_o.ActionList.Add((this.ActionList(i) != null) ? this.ActionList(i).Value.UnPack() : null);
			}
		}

		// Token: 0x060324B8 RID: 206008 RVA: 0x006CB128 File Offset: 0x006C9328
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

		// Token: 0x0401191F RID: 71967
		private Table __p;
	}
}
