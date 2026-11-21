using System;
using System.Collections.Generic;
using Aki.UniverseEditor.Interface.Fbs.Action;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Component
{
	// Token: 0x02005ADA RID: 23258
	public struct IMechTransformHook : IFlatbufferObject
	{
		// Token: 0x1700A9AB RID: 43435
		// (get) Token: 0x060262F2 RID: 156402 RVA: 0x0053B973 File Offset: 0x00539B73
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x060262F3 RID: 156403 RVA: 0x0053B980 File Offset: 0x00539B80
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x060262F4 RID: 156404 RVA: 0x0053B988 File Offset: 0x00539B88
		public static IMechTransformHook GetRootAsIMechTransformHook(ByteBuffer _bb)
		{
			return IMechTransformHook.GetRootAsIMechTransformHook(_bb, default(IMechTransformHook));
		}

		// Token: 0x060262F5 RID: 156405 RVA: 0x0053B9A4 File Offset: 0x00539BA4
		public static IMechTransformHook GetRootAsIMechTransformHook(ByteBuffer _bb, IMechTransformHook obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x060262F6 RID: 156406 RVA: 0x0053B9C1 File Offset: 0x00539BC1
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x060262F7 RID: 156407 RVA: 0x0053B9D0 File Offset: 0x00539BD0
		public IMechTransformHook __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700A9AC RID: 43436
		// (get) Token: 0x060262F8 RID: 156408 RVA: 0x0053B9E0 File Offset: 0x00539BE0
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

		// Token: 0x060262F9 RID: 156409 RVA: 0x0053BA1C File Offset: 0x00539C1C
		public IActionInfo? HookActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9AD RID: 43437
		// (get) Token: 0x060262FA RID: 156410 RVA: 0x0053BA7C File Offset: 0x00539C7C
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

		// Token: 0x060262FB RID: 156411 RVA: 0x0053BAA8 File Offset: 0x00539CA8
		public IActionInfo? ExitHookActions(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9AE RID: 43438
		// (get) Token: 0x060262FC RID: 156412 RVA: 0x0053BB08 File Offset: 0x00539D08
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

		// Token: 0x060262FD RID: 156413 RVA: 0x0053BB34 File Offset: 0x00539D34
		public IActionInfo? FinishActions(int j)
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700A9AF RID: 43439
		// (get) Token: 0x060262FE RID: 156414 RVA: 0x0053BB98 File Offset: 0x00539D98
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

		// Token: 0x1700A9B0 RID: 43440
		// (get) Token: 0x060262FF RID: 156415 RVA: 0x0053BBC4 File Offset: 0x00539DC4
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

		// Token: 0x1700A9B1 RID: 43441
		// (get) Token: 0x06026300 RID: 156416 RVA: 0x0053BC24 File Offset: 0x00539E24
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

		// Token: 0x06026301 RID: 156417 RVA: 0x0053BC61 File Offset: 0x00539E61
		public static Offset<IMechTransformHook> CreateIMechTransformHook(FlatBufferBuilder builder, EHookInteractType Type = EHookInteractType.FixedPointHook, VectorOffset HookActionsOffset = default(VectorOffset), VectorOffset ExitHookActionsOffset = default(VectorOffset), VectorOffset FinishActionsOffset = default(VectorOffset), Offset<IClientHookActionConfig> ClientHookActionConfigOffset = default(Offset<IClientHookActionConfig>), byte NullMask = 0)
		{
			builder.StartTable(6);
			IMechTransformHook.AddClientHookActionConfig(builder, ClientHookActionConfigOffset);
			IMechTransformHook.AddFinishActions(builder, FinishActionsOffset);
			IMechTransformHook.AddExitHookActions(builder, ExitHookActionsOffset);
			IMechTransformHook.AddHookActions(builder, HookActionsOffset);
			IMechTransformHook.AddNullMask(builder, NullMask);
			IMechTransformHook.AddType(builder, Type);
			return IMechTransformHook.EndIMechTransformHook(builder);
		}

		// Token: 0x06026302 RID: 156418 RVA: 0x0053BC9D File Offset: 0x00539E9D
		public static void StartIMechTransformHook(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x06026303 RID: 156419 RVA: 0x0053BCA6 File Offset: 0x00539EA6
		public static void AddType(FlatBufferBuilder builder, EHookInteractType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06026304 RID: 156420 RVA: 0x0053BCB1 File Offset: 0x00539EB1
		public static void AddHookActions(FlatBufferBuilder builder, VectorOffset hookActionsOffset)
		{
			builder.AddOffset(1, hookActionsOffset.Value, 0);
		}

		// Token: 0x06026305 RID: 156421 RVA: 0x0053BCC4 File Offset: 0x00539EC4
		public static VectorOffset CreateHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026306 RID: 156422 RVA: 0x0053BD04 File Offset: 0x00539F04
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026307 RID: 156423 RVA: 0x0053BD1E File Offset: 0x00539F1E
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026308 RID: 156424 RVA: 0x0053BD3C File Offset: 0x00539F3C
		public static VectorOffset CreateHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026309 RID: 156425 RVA: 0x0053BD55 File Offset: 0x00539F55
		public static void StartHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602630A RID: 156426 RVA: 0x0053BD60 File Offset: 0x00539F60
		public static void AddExitHookActions(FlatBufferBuilder builder, VectorOffset exitHookActionsOffset)
		{
			builder.AddOffset(2, exitHookActionsOffset.Value, 0);
		}

		// Token: 0x0602630B RID: 156427 RVA: 0x0053BD70 File Offset: 0x00539F70
		public static VectorOffset CreateExitHookActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602630C RID: 156428 RVA: 0x0053BDB0 File Offset: 0x00539FB0
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602630D RID: 156429 RVA: 0x0053BDCA File Offset: 0x00539FCA
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602630E RID: 156430 RVA: 0x0053BDE8 File Offset: 0x00539FE8
		public static VectorOffset CreateExitHookActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602630F RID: 156431 RVA: 0x0053BE01 File Offset: 0x0053A001
		public static void StartExitHookActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026310 RID: 156432 RVA: 0x0053BE0C File Offset: 0x0053A00C
		public static void AddFinishActions(FlatBufferBuilder builder, VectorOffset finishActionsOffset)
		{
			builder.AddOffset(3, finishActionsOffset.Value, 0);
		}

		// Token: 0x06026311 RID: 156433 RVA: 0x0053BE1C File Offset: 0x0053A01C
		public static VectorOffset CreateFinishActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06026312 RID: 156434 RVA: 0x0053BE5C File Offset: 0x0053A05C
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026313 RID: 156435 RVA: 0x0053BE76 File Offset: 0x0053A076
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06026314 RID: 156436 RVA: 0x0053BE94 File Offset: 0x0053A094
		public static VectorOffset CreateFinishActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06026315 RID: 156437 RVA: 0x0053BEAD File Offset: 0x0053A0AD
		public static void StartFinishActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06026316 RID: 156438 RVA: 0x0053BEB8 File Offset: 0x0053A0B8
		public static void AddClientHookActionConfig(FlatBufferBuilder builder, Offset<IClientHookActionConfig> clientHookActionConfigOffset)
		{
			builder.AddOffset(4, clientHookActionConfigOffset.Value, 0);
		}

		// Token: 0x06026317 RID: 156439 RVA: 0x0053BEC8 File Offset: 0x0053A0C8
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x06026318 RID: 156440 RVA: 0x0053BED3 File Offset: 0x0053A0D3
		public static Offset<IMechTransformHook> EndIMechTransformHook(FlatBufferBuilder builder)
		{
			return new Offset<IMechTransformHook>(builder.EndTable());
		}

		// Token: 0x06026319 RID: 156441 RVA: 0x0053BEE0 File Offset: 0x0053A0E0
		public IMechTransformHookT UnPack()
		{
			IMechTransformHookT mechTransformHookT = new IMechTransformHookT();
			this.UnPackTo(mechTransformHookT);
			return mechTransformHookT;
		}

		// Token: 0x0602631A RID: 156442 RVA: 0x0053BEFC File Offset: 0x0053A0FC
		public void UnPackTo(IMechTransformHookT _o)
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

		// Token: 0x0602631B RID: 156443 RVA: 0x0053C050 File Offset: 0x0053A250
		public static Offset<IMechTransformHook> Pack(FlatBufferBuilder builder, IMechTransformHookT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMechTransformHook>);
			}
			VectorOffset hookActionsOffset = default(VectorOffset);
			if (_o.HookActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.HookActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.HookActions[i]);
				}
				hookActionsOffset = IMechTransformHook.CreateHookActionsVector(builder, array);
			}
			VectorOffset exitHookActionsOffset = default(VectorOffset);
			if (_o.ExitHookActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.ExitHookActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.ExitHookActions[j]);
				}
				exitHookActionsOffset = IMechTransformHook.CreateExitHookActionsVector(builder, array2);
			}
			VectorOffset finishActionsOffset = default(VectorOffset);
			if (_o.FinishActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.FinishActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.FinishActions[k]);
				}
				finishActionsOffset = IMechTransformHook.CreateFinishActionsVector(builder, array3);
			}
			Offset<IClientHookActionConfig> clientHookActionConfigOffset = (_o.ClientHookActionConfig == null) ? default(Offset<IClientHookActionConfig>) : IClientHookActionConfig.Pack(builder, _o.ClientHookActionConfig);
			return IMechTransformHook.CreateIMechTransformHook(builder, _o.Type, hookActionsOffset, exitHookActionsOffset, finishActionsOffset, clientHookActionConfigOffset, _o.NullMask);
		}

		// Token: 0x0400F4A4 RID: 62628
		private Table __p;
	}
}
