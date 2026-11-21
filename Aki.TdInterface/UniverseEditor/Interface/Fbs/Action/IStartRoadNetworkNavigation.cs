using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007989 RID: 31113
	public struct IStartRoadNetworkNavigation : IFlatbufferObject
	{
		// Token: 0x1700E425 RID: 58405
		// (get) Token: 0x06036CD4 RID: 224468 RVA: 0x0075489E File Offset: 0x00752A9E
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06036CD5 RID: 224469 RVA: 0x007548AB File Offset: 0x00752AAB
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06036CD6 RID: 224470 RVA: 0x007548B4 File Offset: 0x00752AB4
		public static IStartRoadNetworkNavigation GetRootAsIStartRoadNetworkNavigation(ByteBuffer _bb)
		{
			return IStartRoadNetworkNavigation.GetRootAsIStartRoadNetworkNavigation(_bb, default(IStartRoadNetworkNavigation));
		}

		// Token: 0x06036CD7 RID: 224471 RVA: 0x007548D0 File Offset: 0x00752AD0
		public static IStartRoadNetworkNavigation GetRootAsIStartRoadNetworkNavigation(ByteBuffer _bb, IStartRoadNetworkNavigation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06036CD8 RID: 224472 RVA: 0x007548ED File Offset: 0x00752AED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06036CD9 RID: 224473 RVA: 0x007548FC File Offset: 0x00752AFC
		public IStartRoadNetworkNavigation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E426 RID: 58406
		// (get) Token: 0x06036CDA RID: 224474 RVA: 0x0075490C File Offset: 0x00752B0C
		public ISceneItemRoadNetworkNavigation? Target
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return null;
				}
				return new ISceneItemRoadNetworkNavigation?(default(ISceneItemRoadNetworkNavigation).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E427 RID: 58407
		// (get) Token: 0x06036CDB RID: 224475 RVA: 0x0075496C File Offset: 0x00752B6C
		public ISplineWayPoint? Start
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ISplineWayPoint?(default(ISplineWayPoint).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700E428 RID: 58408
		// (get) Token: 0x06036CDC RID: 224476 RVA: 0x007549CC File Offset: 0x00752BCC
		public ISplineWayPoint? End
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new ISplineWayPoint?(default(ISplineWayPoint).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06036CDD RID: 224477 RVA: 0x00754A29 File Offset: 0x00752C29
		public static Offset<IStartRoadNetworkNavigation> CreateIStartRoadNetworkNavigation(FlatBufferBuilder builder, Offset<ISceneItemRoadNetworkNavigation> TargetOffset = default(Offset<ISceneItemRoadNetworkNavigation>), Offset<ISplineWayPoint> StartOffset = default(Offset<ISplineWayPoint>), Offset<ISplineWayPoint> EndOffset = default(Offset<ISplineWayPoint>))
		{
			builder.StartTable(3);
			IStartRoadNetworkNavigation.AddEnd(builder, EndOffset);
			IStartRoadNetworkNavigation.AddStart(builder, StartOffset);
			IStartRoadNetworkNavigation.AddTarget(builder, TargetOffset);
			return IStartRoadNetworkNavigation.EndIStartRoadNetworkNavigation(builder);
		}

		// Token: 0x06036CDE RID: 224478 RVA: 0x00754A4D File Offset: 0x00752C4D
		public static void StartIStartRoadNetworkNavigation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06036CDF RID: 224479 RVA: 0x00754A56 File Offset: 0x00752C56
		public static void AddTarget(FlatBufferBuilder builder, Offset<ISceneItemRoadNetworkNavigation> targetOffset)
		{
			builder.AddOffset(0, targetOffset.Value, 0);
		}

		// Token: 0x06036CE0 RID: 224480 RVA: 0x00754A66 File Offset: 0x00752C66
		public static void AddStart(FlatBufferBuilder builder, Offset<ISplineWayPoint> startOffset)
		{
			builder.AddOffset(1, startOffset.Value, 0);
		}

		// Token: 0x06036CE1 RID: 224481 RVA: 0x00754A76 File Offset: 0x00752C76
		public static void AddEnd(FlatBufferBuilder builder, Offset<ISplineWayPoint> endOffset)
		{
			builder.AddOffset(2, endOffset.Value, 0);
		}

		// Token: 0x06036CE2 RID: 224482 RVA: 0x00754A86 File Offset: 0x00752C86
		public static Offset<IStartRoadNetworkNavigation> EndIStartRoadNetworkNavigation(FlatBufferBuilder builder)
		{
			return new Offset<IStartRoadNetworkNavigation>(builder.EndTable());
		}

		// Token: 0x06036CE3 RID: 224483 RVA: 0x00754A94 File Offset: 0x00752C94
		public IStartRoadNetworkNavigationT UnPack()
		{
			IStartRoadNetworkNavigationT startRoadNetworkNavigationT = new IStartRoadNetworkNavigationT();
			this.UnPackTo(startRoadNetworkNavigationT);
			return startRoadNetworkNavigationT;
		}

		// Token: 0x06036CE4 RID: 224484 RVA: 0x00754AB0 File Offset: 0x00752CB0
		public void UnPackTo(IStartRoadNetworkNavigationT _o)
		{
			_o.Target = ((this.Target != null) ? this.Target.Value.UnPack() : null);
			_o.Start = ((this.Start != null) ? this.Start.Value.UnPack() : null);
			_o.End = ((this.End != null) ? this.End.Value.UnPack() : null);
		}

		// Token: 0x06036CE5 RID: 224485 RVA: 0x00754B4C File Offset: 0x00752D4C
		public static Offset<IStartRoadNetworkNavigation> Pack(FlatBufferBuilder builder, IStartRoadNetworkNavigationT _o)
		{
			if (_o == null)
			{
				return default(Offset<IStartRoadNetworkNavigation>);
			}
			Offset<ISceneItemRoadNetworkNavigation> targetOffset = (_o.Target == null) ? default(Offset<ISceneItemRoadNetworkNavigation>) : ISceneItemRoadNetworkNavigation.Pack(builder, _o.Target);
			Offset<ISplineWayPoint> startOffset = (_o.Start == null) ? default(Offset<ISplineWayPoint>) : ISplineWayPoint.Pack(builder, _o.Start);
			Offset<ISplineWayPoint> endOffset = (_o.End == null) ? default(Offset<ISplineWayPoint>) : ISplineWayPoint.Pack(builder, _o.End);
			return IStartRoadNetworkNavigation.CreateIStartRoadNetworkNavigation(builder, targetOffset, startOffset, endOffset);
		}

		// Token: 0x04012C80 RID: 76928
		private Table __p;
	}
}
