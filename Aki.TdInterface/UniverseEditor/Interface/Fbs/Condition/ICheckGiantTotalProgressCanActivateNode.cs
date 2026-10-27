using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Condition
{
	// Token: 0x02004A3C RID: 19004
	public struct ICheckGiantTotalProgressCanActivateNode : IFlatbufferObject
	{
		// Token: 0x17008995 RID: 35221
		// (get) Token: 0x0601DC0C RID: 121868 RVA: 0x0042F2A0 File Offset: 0x0042D4A0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0601DC0D RID: 121869 RVA: 0x0042F2AD File Offset: 0x0042D4AD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0601DC0E RID: 121870 RVA: 0x0042F2B4 File Offset: 0x0042D4B4
		public static ICheckGiantTotalProgressCanActivateNode GetRootAsICheckGiantTotalProgressCanActivateNode(ByteBuffer _bb)
		{
			return ICheckGiantTotalProgressCanActivateNode.GetRootAsICheckGiantTotalProgressCanActivateNode(_bb, default(ICheckGiantTotalProgressCanActivateNode));
		}

		// Token: 0x0601DC0F RID: 121871 RVA: 0x0042F2D0 File Offset: 0x0042D4D0
		public static ICheckGiantTotalProgressCanActivateNode GetRootAsICheckGiantTotalProgressCanActivateNode(ByteBuffer _bb, ICheckGiantTotalProgressCanActivateNode obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0601DC10 RID: 121872 RVA: 0x0042F2ED File Offset: 0x0042D4ED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0601DC11 RID: 121873 RVA: 0x0042F2FC File Offset: 0x0042D4FC
		public ICheckGiantTotalProgressCanActivateNode __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17008996 RID: 35222
		// (get) Token: 0x0601DC12 RID: 121874 RVA: 0x0042F30C File Offset: 0x0042D50C
		public ECondition Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ECondition.CompareVar;
				}
				return (ECondition)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x17008997 RID: 35223
		// (get) Token: 0x0601DC13 RID: 121875 RVA: 0x0042F348 File Offset: 0x0042D548
		public bool HasActivateNode
		{
			get
			{
				int num = this.__p.__offset(6);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x0601DC14 RID: 121876 RVA: 0x0042F387 File Offset: 0x0042D587
		public static Offset<ICheckGiantTotalProgressCanActivateNode> CreateICheckGiantTotalProgressCanActivateNode(FlatBufferBuilder builder, ECondition Type = ECondition.CompareVar, bool HasActivateNode = false)
		{
			builder.StartTable(2);
			ICheckGiantTotalProgressCanActivateNode.AddHasActivateNode(builder, HasActivateNode);
			ICheckGiantTotalProgressCanActivateNode.AddType(builder, Type);
			return ICheckGiantTotalProgressCanActivateNode.EndICheckGiantTotalProgressCanActivateNode(builder);
		}

		// Token: 0x0601DC15 RID: 121877 RVA: 0x0042F3A4 File Offset: 0x0042D5A4
		public static void StartICheckGiantTotalProgressCanActivateNode(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0601DC16 RID: 121878 RVA: 0x0042F3AD File Offset: 0x0042D5AD
		public static void AddType(FlatBufferBuilder builder, ECondition type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0601DC17 RID: 121879 RVA: 0x0042F3B8 File Offset: 0x0042D5B8
		public static void AddHasActivateNode(FlatBufferBuilder builder, bool hasActivateNode)
		{
			builder.AddBool(1, hasActivateNode, false);
		}

		// Token: 0x0601DC18 RID: 121880 RVA: 0x0042F3C3 File Offset: 0x0042D5C3
		public static Offset<ICheckGiantTotalProgressCanActivateNode> EndICheckGiantTotalProgressCanActivateNode(FlatBufferBuilder builder)
		{
			return new Offset<ICheckGiantTotalProgressCanActivateNode>(builder.EndTable());
		}

		// Token: 0x0601DC19 RID: 121881 RVA: 0x0042F3D0 File Offset: 0x0042D5D0
		public ICheckGiantTotalProgressCanActivateNodeT UnPack()
		{
			ICheckGiantTotalProgressCanActivateNodeT checkGiantTotalProgressCanActivateNodeT = new ICheckGiantTotalProgressCanActivateNodeT();
			this.UnPackTo(checkGiantTotalProgressCanActivateNodeT);
			return checkGiantTotalProgressCanActivateNodeT;
		}

		// Token: 0x0601DC1A RID: 121882 RVA: 0x0042F3EB File Offset: 0x0042D5EB
		public void UnPackTo(ICheckGiantTotalProgressCanActivateNodeT _o)
		{
			_o.Type = this.Type;
			_o.HasActivateNode = this.HasActivateNode;
		}

		// Token: 0x0601DC1B RID: 121883 RVA: 0x0042F408 File Offset: 0x0042D608
		public static Offset<ICheckGiantTotalProgressCanActivateNode> Pack(FlatBufferBuilder builder, ICheckGiantTotalProgressCanActivateNodeT _o)
		{
			if (_o == null)
			{
				return default(Offset<ICheckGiantTotalProgressCanActivateNode>);
			}
			return ICheckGiantTotalProgressCanActivateNode.CreateICheckGiantTotalProgressCanActivateNode(builder, _o.Type, _o.HasActivateNode);
		}

		// Token: 0x0400D292 RID: 53906
		private Table __p;
	}
}
