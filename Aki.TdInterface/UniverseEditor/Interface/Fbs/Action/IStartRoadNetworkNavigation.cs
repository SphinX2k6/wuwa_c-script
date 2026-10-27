using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x020071B4 RID: 29108
	public struct IStartRoadNetworkNavigation : IFlatbufferObject
	{
		// Token: 0x1700D82E RID: 55342
		// (get) Token: 0x060339D6 RID: 211414 RVA: 0x006F35D2 File Offset: 0x006F17D2
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060339D7 RID: 211415 RVA: 0x006F35DF File Offset: 0x006F17DF
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060339D8 RID: 211416 RVA: 0x006F35E8 File Offset: 0x006F17E8
		public static IStartRoadNetworkNavigation GetRootAsIStartRoadNetworkNavigation(ByteBuffer _bb)
		{
			return IStartRoadNetworkNavigation.GetRootAsIStartRoadNetworkNavigation(_bb, default(IStartRoadNetworkNavigation));
		}

		// Token: 0x060339D9 RID: 211417 RVA: 0x006F3604 File Offset: 0x006F1804
		public static IStartRoadNetworkNavigation GetRootAsIStartRoadNetworkNavigation(ByteBuffer _bb, IStartRoadNetworkNavigation obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060339DA RID: 211418 RVA: 0x006F3621 File Offset: 0x006F1821
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060339DB RID: 211419 RVA: 0x006F3630 File Offset: 0x006F1830
		public IStartRoadNetworkNavigation __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D82F RID: 55343
		// (get) Token: 0x060339DC RID: 211420 RVA: 0x006F3640 File Offset: 0x006F1840
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

		// Token: 0x1700D830 RID: 55344
		// (get) Token: 0x060339DD RID: 211421 RVA: 0x006F36A0 File Offset: 0x006F18A0
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

		// Token: 0x1700D831 RID: 55345
		// (get) Token: 0x060339DE RID: 211422 RVA: 0x006F3700 File Offset: 0x006F1900
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

		// Token: 0x060339DF RID: 211423 RVA: 0x006F375D File Offset: 0x006F195D
		public static Offset<IStartRoadNetworkNavigation> CreateIStartRoadNetworkNavigation(FlatBufferBuilder builder, Offset<ISceneItemRoadNetworkNavigation> TargetOffset = default(Offset<ISceneItemRoadNetworkNavigation>), Offset<ISplineWayPoint> StartOffset = default(Offset<ISplineWayPoint>), Offset<ISplineWayPoint> EndOffset = default(Offset<ISplineWayPoint>))
		{
			builder.StartTable(3);
			IStartRoadNetworkNavigation.AddEnd(builder, EndOffset);
			IStartRoadNetworkNavigation.AddStart(builder, StartOffset);
			IStartRoadNetworkNavigation.AddTarget(builder, TargetOffset);
			return IStartRoadNetworkNavigation.EndIStartRoadNetworkNavigation(builder);
		}

		// Token: 0x060339E0 RID: 211424 RVA: 0x006F3781 File Offset: 0x006F1981
		public static void StartIStartRoadNetworkNavigation(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x060339E1 RID: 211425 RVA: 0x006F378A File Offset: 0x006F198A
		public static void AddTarget(FlatBufferBuilder builder, Offset<ISceneItemRoadNetworkNavigation> targetOffset)
		{
			builder.AddOffset(0, targetOffset.Value, 0);
		}

		// Token: 0x060339E2 RID: 211426 RVA: 0x006F379A File Offset: 0x006F199A
		public static void AddStart(FlatBufferBuilder builder, Offset<ISplineWayPoint> startOffset)
		{
			builder.AddOffset(1, startOffset.Value, 0);
		}

		// Token: 0x060339E3 RID: 211427 RVA: 0x006F37AA File Offset: 0x006F19AA
		public static void AddEnd(FlatBufferBuilder builder, Offset<ISplineWayPoint> endOffset)
		{
			builder.AddOffset(2, endOffset.Value, 0);
		}

		// Token: 0x060339E4 RID: 211428 RVA: 0x006F37BA File Offset: 0x006F19BA
		public static Offset<IStartRoadNetworkNavigation> EndIStartRoadNetworkNavigation(FlatBufferBuilder builder)
		{
			return new Offset<IStartRoadNetworkNavigation>(builder.EndTable());
		}

		// Token: 0x060339E5 RID: 211429 RVA: 0x006F37C8 File Offset: 0x006F19C8
		public IStartRoadNetworkNavigationT UnPack()
		{
			IStartRoadNetworkNavigationT startRoadNetworkNavigationT = new IStartRoadNetworkNavigationT();
			this.UnPackTo(startRoadNetworkNavigationT);
			return startRoadNetworkNavigationT;
		}

		// Token: 0x060339E6 RID: 211430 RVA: 0x006F37E4 File Offset: 0x006F19E4
		public void UnPackTo(IStartRoadNetworkNavigationT _o)
		{
			_o.Target = ((this.Target != null) ? this.Target.Value.UnPack() : null);
			_o.Start = ((this.Start != null) ? this.Start.Value.UnPack() : null);
			_o.End = ((this.End != null) ? this.End.Value.UnPack() : null);
		}

		// Token: 0x060339E7 RID: 211431 RVA: 0x006F3880 File Offset: 0x006F1A80
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

		// Token: 0x04011C7F RID: 72831
		private Table __p;
	}
}
