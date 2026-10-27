using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x020053C2 RID: 21442
	public struct IHookInteractType : IFlatbufferObject
	{
		// Token: 0x17009D9A RID: 40346
		// (get) Token: 0x06023244 RID: 143940 RVA: 0x004DD4C4 File Offset: 0x004DB6C4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06023245 RID: 143941 RVA: 0x004DD4D1 File Offset: 0x004DB6D1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06023246 RID: 143942 RVA: 0x004DD4D8 File Offset: 0x004DB6D8
		public static IHookInteractType GetRootAsIHookInteractType(ByteBuffer _bb)
		{
			return IHookInteractType.GetRootAsIHookInteractType(_bb, default(IHookInteractType));
		}

		// Token: 0x06023247 RID: 143943 RVA: 0x004DD4F4 File Offset: 0x004DB6F4
		public static IHookInteractType GetRootAsIHookInteractType(ByteBuffer _bb, IHookInteractType obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x06023248 RID: 143944 RVA: 0x004DD511 File Offset: 0x004DB711
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x06023249 RID: 143945 RVA: 0x004DD520 File Offset: 0x004DB720
		public IHookInteractType __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x17009D9B RID: 40347
		// (get) Token: 0x0602324A RID: 143946 RVA: 0x004DD530 File Offset: 0x004DB730
		public EHookInteractType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EHookInteractType.FixedPointHook;
				}
				return (EHookInteractType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602324B RID: 143947 RVA: 0x004DD56C File Offset: 0x004DB76C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D9C RID: 40348
		// (get) Token: 0x0602324C RID: 143948 RVA: 0x004DD5CC File Offset: 0x004DB7CC
		public int HookActionsLength
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

		// Token: 0x0602324D RID: 143949 RVA: 0x004DD5F8 File Offset: 0x004DB7F8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D9D RID: 40349
		// (get) Token: 0x0602324E RID: 143950 RVA: 0x004DD658 File Offset: 0x004DB858
		public int ExitHookActionsLength
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

		// Token: 0x0602324F RID: 143951 RVA: 0x004DD684 File Offset: 0x004DB884
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x17009D9E RID: 40350
		// (get) Token: 0x06023250 RID: 143952 RVA: 0x004DD6E8 File Offset: 0x004DB8E8
		public int FinishActionsLength
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

		// Token: 0x17009D9F RID: 40351
		// (get) Token: 0x06023251 RID: 143953 RVA: 0x004DD714 File Offset: 0x004DB914
		public IClientHookActionConfig? ClientHookActionConfig
		{
			get
			{
				int num = this.__p.__offset(12);
				if (num == 0)
				{
					return null;
				}
				return new IClientHookActionConfig?(default(IClientHookActionConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x17009DA0 RID: 40352
		// (get) Token: 0x06023252 RID: 143954 RVA: 0x004DD774 File Offset: 0x004DB974
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06023253 RID: 143955 RVA: 0x004DD7B1 File Offset: 0x004DB9B1
		public static Offset<IHookInteractType> CreateIHookInteractType(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IHookInteractType.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IHookInteractType.AddFinishActions(builder, FinishActionsOffset);
			IHookInteractType.AddExitHookActions(builder, ExitHookActionsOffset);
			IHookInteractType.AddHookActions(builder, HookActionsOffset);
			IHookInteractType.AddNullMask(builder, NullMask);
			IHookInteractType.AddType(builder, Type);
			return IHookInteractType.EndIHookInteractType(builder);
		}

		// Token: 0x06023254 RID: 143956 RVA: 0x004DD7ED File Offset: 0x004DB9ED
		public static void StartIHookInteractType(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06023255 RID: 143957 RVA: 0x004DD7F6 File Offset: 0x004DB9F6
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06023256 RID: 143958 RVA: 0x004DD801 File Offset: 0x004DBA01
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06023257 RID: 143959 RVA: 0x004DD814 File Offset: 0x004DBA14
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023258 RID: 143960 RVA: 0x004DD854 File Offset: 0x004DBA54
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023259 RID: 143961 RVA: 0x004DD86E File Offset: 0x004DBA6E
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602325A RID: 143962 RVA: 0x004DD88C File Offset: 0x004DBA8C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602325B RID: 143963 RVA: 0x004DD8A5 File Offset: 0x004DBAA5
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602325C RID: 143964 RVA: 0x004DD8B0 File Offset: 0x004DBAB0
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602325D RID: 143965 RVA: 0x004DD8C0 File Offset: 0x004DBAC0
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602325E RID: 143966 RVA: 0x004DD900 File Offset: 0x004DBB00
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602325F RID: 143967 RVA: 0x004DD91A File Offset: 0x004DBB1A
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023260 RID: 143968 RVA: 0x004DD938 File Offset: 0x004DBB38
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023261 RID: 143969 RVA: 0x004DD951 File Offset: 0x004DBB51
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023262 RID: 143970 RVA: 0x004DD95C File Offset: 0x004DBB5C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06023263 RID: 143971 RVA: 0x004DD96C File Offset: 0x004DBB6C
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06023264 RID: 143972 RVA: 0x004DD9AC File Offset: 0x004DBBAC
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023265 RID: 143973 RVA: 0x004DD9C6 File Offset: 0x004DBBC6
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06023266 RID: 143974 RVA: 0x004DD9E4 File Offset: 0x004DBBE4
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06023267 RID: 143975 RVA: 0x004DD9FD File Offset: 0x004DBBFD
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06023268 RID: 143976 RVA: 0x004DDA08 File Offset: 0x004DBC08
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06023269 RID: 143977 RVA: 0x004DDA18 File Offset: 0x004DBC18
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0602326A RID: 143978 RVA: 0x004DDA23 File Offset: 0x004DBC23
		public static Offset<IHookInteractType> EndIHookInteractType(FlatBufferBuilder builder)
		{
			return new Offset<IHookInteractType>(builder.EndTable());
		}

		// Token: 0x0602326B RID: 143979 RVA: 0x004DDA30 File Offset: 0x004DBC30
		public IHookInteractTypeT UnPack()
		{
			IHookInteractTypeT hookInteractTypeT = new IHookInteractTypeT();
			this.UnPackTo(hookInteractTypeT);
			return hookInteractTypeT;
		}

		// Token: 0x0602326C RID: 143980 RVA: 0x004DDA4C File Offset: 0x004DBC4C
		public void UnPackTo(IHookInteractTypeT _o)
		{
			_o.Type = this.Type;
			_o.HookActions = new List<IActionInfoT>();
			for (int i = 0; i < this.HookActionsLength; i++)
			{
				_o.HookActions.Add((this.HookActions(i) != null) ? this.HookActions(i).Value.UnPack() : null);
			}
			_o.ExitHookActions = new List<IActionInfoT>();
			for (int j = 0; j < this.ExitHookActionsLength; j++)
			{
				_o.ExitHookActions.Add((this.ExitHookActions(j) != null) ? this.ExitHookActions(j).Value.UnPack() : null);
			}
			_o.FinishActions = new List<IActionInfoT>();
			for (int k = 0; k < this.FinishActionsLength; k++)
			{
				_o.FinishActions.Add((this.FinishActions(k) != null) ? this.FinishActions(k).Value.UnPack() : null);
			}
			_o.ClientHookActionConfig = ((this.ClientHookActionConfig != null) ? this.ClientHookActionConfig.Value.UnPack() : null);
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602326D RID: 143981 RVA: 0x004DDBA0 File Offset: 0x004DBDA0
		public static Offset<IHookInteractType> Pack(FlatBufferBuilder builder, IHookInteractTypeT _o)
		{
			if (_o == null)
			{
				return default(Offset<IHookInteractType>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IHookInteractType.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IHookInteractType.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IHookInteractType.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IHookInteractType.CreateIHookInteractType(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400E5C6 RID: 58822
		private Table __p;
	}
}
