using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006A3E RID: 27198
	public struct ILongPressInteractConfig : IFlatbufferObject
	{
		// Token: 0x1700C9C0 RID: 51648
		// (get) Token: 0x0602F9B4 RID: 194996 RVA: 0x0067AB87 File Offset: 0x00678D87
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602F9B5 RID: 194997 RVA: 0x0067AB94 File Offset: 0x00678D94
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602F9B6 RID: 194998 RVA: 0x0067AB9C File Offset: 0x00678D9C
		public static ILongPressInteractConfig GetRootAsILongPressInteractConfig(ByteBuffer _bb)
		{
			return ILongPressInteractConfig.GetRootAsILongPressInteractConfig(_bb, default(ILongPressInteractConfig));
		}

		// Token: 0x0602F9B7 RID: 194999 RVA: 0x0067ABB8 File Offset: 0x00678DB8
		public static ILongPressInteractConfig GetRootAsILongPressInteractConfig(ByteBuffer _bb, ILongPressInteractConfig obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602F9B8 RID: 195000 RVA: 0x0067ABD5 File Offset: 0x00678DD5
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602F9B9 RID: 195001 RVA: 0x0067ABE4 File Offset: 0x00678DE4
		public ILongPressInteractConfig __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700C9C1 RID: 51649
		// (get) Token: 0x0602F9BA RID: 195002 RVA: 0x0067ABF4 File Offset: 0x00678DF4
		public float PressDuration
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return 0f;
				}
				return this.__p.bb.GetFloat(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700C9C2 RID: 51650
		// (get) Token: 0x0602F9BB RID: 195003 RVA: 0x0067AC34 File Offset: 0x00678E34
		public ILongPressEffectConfig? PressEffect
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return null;
				}
				return new ILongPressEffectConfig?(default(ILongPressEffectConfig).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x1700C9C3 RID: 51651
		// (get) Token: 0x0602F9BC RID: 195004 RVA: 0x0067AC94 File Offset: 0x00678E94
		public TLongPressInteractStyleConfig StyleType
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return TLongPressInteractStyleConfig.NONE;
				}
				return (TLongPressInteractStyleConfig)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F9BD RID: 195005 RVA: 0x0067ACD0 File Offset: 0x00678ED0
		public TTable? Style<TTable>() where TTable : struct, IFlatbufferObject
		{
			int num = this.__p.__offset(10);
			if (num == 0)
			{
				return null;
			}
			return new TTable?(this.__p.__union<TTable>(num + this.__p.bb_pos));
		}

		// Token: 0x0602F9BE RID: 195006 RVA: 0x0067AD18 File Offset: 0x00678F18
		public ILongPressInteractStyleConfigDefault StyleAsILongPressInteractStyleConfigDefault()
		{
			return this.Style<ILongPressInteractStyleConfigDefault>().Value;
		}

		// Token: 0x0602F9BF RID: 195007 RVA: 0x0067AD34 File Offset: 0x00678F34
		public ILongPressInteractStyleConfigTimeBackInteract StyleAsILongPressInteractStyleConfigTimeBackInteract()
		{
			return this.Style<ILongPressInteractStyleConfigTimeBackInteract>().Value;
		}

		// Token: 0x0602F9C0 RID: 195008 RVA: 0x0067AD50 File Offset: 0x00678F50
		public ILongPressInteractStyleCoreFix StyleAsILongPressInteractStyleCoreFix()
		{
			return this.Style<ILongPressInteractStyleCoreFix>().Value;
		}

		// Token: 0x0602F9C1 RID: 195009 RVA: 0x0067AD6C File Offset: 0x00678F6C
		public ILongPressInteractStyleSwordRider StyleAsILongPressInteractStyleSwordRider()
		{
			return this.Style<ILongPressInteractStyleSwordRider>().Value;
		}

		// Token: 0x1700C9C4 RID: 51652
		// (get) Token: 0x0602F9C2 RID: 195010 RVA: 0x0067AD88 File Offset: 0x00678F88
		public bool ResetFromCurrentProgress
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700C9C5 RID: 51653
		// (get) Token: 0x0602F9C3 RID: 195011 RVA: 0x0067ADC8 File Offset: 0x00678FC8
		public ILongPressButtonActionMapping? LongPressButtonActionMapping
		{
			get
			{
				int num = this.__p.__offset(14);
				if (num == 0)
				{
					return null;
				}
				return new ILongPressButtonActionMapping?(default(ILongPressButtonActionMapping).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x0602F9C4 RID: 195012 RVA: 0x0067AE28 File Offset: 0x00679028
		public IActionInfo? LongPressStartActions(int j)
		{
			int num = this.__p.__offset(16);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C9C6 RID: 51654
		// (get) Token: 0x0602F9C5 RID: 195013 RVA: 0x0067AE8C File Offset: 0x0067908C
		public int LongPressStartActionsLength
		{
			get
			{
				int num = this.__p.__offset(16);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602F9C6 RID: 195014 RVA: 0x0067AEB8 File Offset: 0x006790B8
		public IActionInfo? LongPressInterruptedActions(int j)
		{
			int num = this.__p.__offset(18);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C9C7 RID: 51655
		// (get) Token: 0x0602F9C7 RID: 195015 RVA: 0x0067AF1C File Offset: 0x0067911C
		public int LongPressInterruptedActionsLength
		{
			get
			{
				int num = this.__p.__offset(18);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602F9C8 RID: 195016 RVA: 0x0067AF48 File Offset: 0x00679148
		public IActionInfo? LongPressSuccessActions(int j)
		{
			int num = this.__p.__offset(20);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C9C8 RID: 51656
		// (get) Token: 0x0602F9C9 RID: 195017 RVA: 0x0067AFAC File Offset: 0x006791AC
		public int LongPressSuccessActionsLength
		{
			get
			{
				int num = this.__p.__offset(20);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x0602F9CA RID: 195018 RVA: 0x0067AFD8 File Offset: 0x006791D8
		public ILongPressProgressAction? LongPressProgressActions(int j)
		{
			int num = this.__p.__offset(22);
			if (num == 0)
			{
				return null;
			}
			return new ILongPressProgressAction?(default(ILongPressProgressAction).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700C9C9 RID: 51657
		// (get) Token: 0x0602F9CB RID: 195019 RVA: 0x0067B03C File Offset: 0x0067923C
		public int LongPressProgressActionsLength
		{
			get
			{
				int num = this.__p.__offset(22);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.__vector_len(num);
			}
		}

		// Token: 0x1700C9CA RID: 51658
		// (get) Token: 0x0602F9CC RID: 195020 RVA: 0x0067B068 File Offset: 0x00679268
		public byte NullMask
		{
			get
			{
				int num = this.__p.__offset(24);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602F9CD RID: 195021 RVA: 0x0067B0A8 File Offset: 0x006792A8
		public static Offset<ILongPressInteractConfig> CreateILongPressInteractConfig(FlatBufferBuilder builder, float PressDuration = 0f, Offset<ILongPressEffectConfig> PressEffectOffset = default(Offset<ILongPressEffectConfig>), TLongPressInteractStyleConfig Style_type = TLongPressInteractStyleConfig.NONE, int StyleOffset = 0, bool ResetFromCurrentProgress = false, Offset<ILongPressButtonActionMapping> LongPressButtonActionMappingOffset = default(Offset<ILongPressButtonActionMapping>), VectorOffset LongPressStartActionsOffset = default(VectorOffset), VectorOffset LongPressInterruptedActionsOffset = default(VectorOffset), VectorOffset LongPressSuccessActionsOffset = default(VectorOffset), VectorOffset LongPressProgressActionsOffset = default(VectorOffset), byte NullMask = 0)
		{
			builder.StartTable(11);
			ILongPressInteractConfig.AddLongPressProgressActions(builder, LongPressProgressActionsOffset);
			ILongPressInteractConfig.AddLongPressSuccessActions(builder, LongPressSuccessActionsOffset);
			ILongPressInteractConfig.AddLongPressInterruptedActions(builder, LongPressInterruptedActionsOffset);
			ILongPressInteractConfig.AddLongPressStartActions(builder, LongPressStartActionsOffset);
			ILongPressInteractConfig.AddLongPressButtonActionMapping(builder, LongPressButtonActionMappingOffset);
			ILongPressInteractConfig.AddStyle(builder, StyleOffset);
			ILongPressInteractConfig.AddPressEffect(builder, PressEffectOffset);
			ILongPressInteractConfig.AddPressDuration(builder, PressDuration);
			ILongPressInteractConfig.AddNullMask(builder, NullMask);
			ILongPressInteractConfig.AddResetFromCurrentProgress(builder, ResetFromCurrentProgress);
			ILongPressInteractConfig.AddStyleType(builder, Style_type);
			return ILongPressInteractConfig.EndILongPressInteractConfig(builder);
		}

		// Token: 0x0602F9CE RID: 195022 RVA: 0x0067B118 File Offset: 0x00679318
		public static void StartILongPressInteractConfig(FlatBufferBuilder builder)
		{
			builder.StartTable(11);
		}

		// Token: 0x0602F9CF RID: 195023 RVA: 0x0067B122 File Offset: 0x00679322
		public static void AddPressDuration(FlatBufferBuilder builder, float pressDuration)
		{
			builder.AddFloat(0, pressDuration, 0.0);
		}

		// Token: 0x0602F9D0 RID: 195024 RVA: 0x0067B135 File Offset: 0x00679335
		public static void AddPressEffect(FlatBufferBuilder builder, Offset<ILongPressEffectConfig> pressEffectOffset)
		{
			builder.AddOffset(1, pressEffectOffset.Value, 0);
		}

		// Token: 0x0602F9D1 RID: 195025 RVA: 0x0067B145 File Offset: 0x00679345
		public static void AddStyleType(FlatBufferBuilder builder, TLongPressInteractStyleConfig styleType)
		{
			builder.AddByte(2, (byte)styleType, 0);
		}

		// Token: 0x0602F9D2 RID: 195026 RVA: 0x0067B150 File Offset: 0x00679350
		public static void AddStyle(FlatBufferBuilder builder, int styleOffset)
		{
			builder.AddOffset(3, styleOffset, 0);
		}

		// Token: 0x0602F9D3 RID: 195027 RVA: 0x0067B15B File Offset: 0x0067935B
		public static void AddResetFromCurrentProgress(FlatBufferBuilder builder, bool resetFromCurrentProgress)
		{
			builder.AddBool(4, resetFromCurrentProgress, false);
		}

		// Token: 0x0602F9D4 RID: 195028 RVA: 0x0067B166 File Offset: 0x00679366
		public static void AddLongPressButtonActionMapping(FlatBufferBuilder builder, Offset<ILongPressButtonActionMapping> longPressButtonActionMappingOffset)
		{
			builder.AddOffset(5, longPressButtonActionMappingOffset.Value, 0);
		}

		// Token: 0x0602F9D5 RID: 195029 RVA: 0x0067B176 File Offset: 0x00679376
		public static void AddLongPressStartActions(FlatBufferBuilder builder, VectorOffset longPressStartActionsOffset)
		{
			builder.AddOffset(6, longPressStartActionsOffset.Value, 0);
		}

		// Token: 0x0602F9D6 RID: 195030 RVA: 0x0067B188 File Offset: 0x00679388
		public static VectorOffset CreateLongPressStartActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F9D7 RID: 195031 RVA: 0x0067B1C8 File Offset: 0x006793C8
		public static VectorOffset CreateLongPressStartActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F9D8 RID: 195032 RVA: 0x0067B1E2 File Offset: 0x006793E2
		public static VectorOffset CreateLongPressStartActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F9D9 RID: 195033 RVA: 0x0067B200 File Offset: 0x00679400
		public static VectorOffset CreateLongPressStartActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F9DA RID: 195034 RVA: 0x0067B219 File Offset: 0x00679419
		public static void StartLongPressStartActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F9DB RID: 195035 RVA: 0x0067B224 File Offset: 0x00679424
		public static void AddLongPressInterruptedActions(FlatBufferBuilder builder, VectorOffset longPressInterruptedActionsOffset)
		{
			builder.AddOffset(7, longPressInterruptedActionsOffset.Value, 0);
		}

		// Token: 0x0602F9DC RID: 195036 RVA: 0x0067B234 File Offset: 0x00679434
		public static VectorOffset CreateLongPressInterruptedActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F9DD RID: 195037 RVA: 0x0067B274 File Offset: 0x00679474
		public static VectorOffset CreateLongPressInterruptedActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F9DE RID: 195038 RVA: 0x0067B28E File Offset: 0x0067948E
		public static VectorOffset CreateLongPressInterruptedActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F9DF RID: 195039 RVA: 0x0067B2AC File Offset: 0x006794AC
		public static VectorOffset CreateLongPressInterruptedActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F9E0 RID: 195040 RVA: 0x0067B2C5 File Offset: 0x006794C5
		public static void StartLongPressInterruptedActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F9E1 RID: 195041 RVA: 0x0067B2D0 File Offset: 0x006794D0
		public static void AddLongPressSuccessActions(FlatBufferBuilder builder, VectorOffset longPressSuccessActionsOffset)
		{
			builder.AddOffset(8, longPressSuccessActionsOffset.Value, 0);
		}

		// Token: 0x0602F9E2 RID: 195042 RVA: 0x0067B2E0 File Offset: 0x006794E0
		public static VectorOffset CreateLongPressSuccessActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F9E3 RID: 195043 RVA: 0x0067B320 File Offset: 0x00679520
		public static VectorOffset CreateLongPressSuccessActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F9E4 RID: 195044 RVA: 0x0067B33A File Offset: 0x0067953A
		public static VectorOffset CreateLongPressSuccessActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F9E5 RID: 195045 RVA: 0x0067B358 File Offset: 0x00679558
		public static VectorOffset CreateLongPressSuccessActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F9E6 RID: 195046 RVA: 0x0067B371 File Offset: 0x00679571
		public static void StartLongPressSuccessActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F9E7 RID: 195047 RVA: 0x0067B37C File Offset: 0x0067957C
		public static void AddLongPressProgressActions(FlatBufferBuilder builder, VectorOffset longPressProgressActionsOffset)
		{
			builder.AddOffset(9, longPressProgressActionsOffset.Value, 0);
		}

		// Token: 0x0602F9E8 RID: 195048 RVA: 0x0067B390 File Offset: 0x00679590
		public static VectorOffset CreateLongPressProgressActionsVector(FlatBufferBuilder builder, Offset<ILongPressProgressAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0602F9E9 RID: 195049 RVA: 0x0067B3D0 File Offset: 0x006795D0
		public static VectorOffset CreateLongPressProgressActionsVectorBlock(FlatBufferBuilder builder, Offset<ILongPressProgressAction>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<ILongPressProgressAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F9EA RID: 195050 RVA: 0x0067B3EA File Offset: 0x006795EA
		public static VectorOffset CreateLongPressProgressActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<ILongPressProgressAction>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<ILongPressProgressAction>>(data);
			return builder.EndVector();
		}

		// Token: 0x0602F9EB RID: 195051 RVA: 0x0067B408 File Offset: 0x00679608
		public static VectorOffset CreateLongPressProgressActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<ILongPressProgressAction>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0602F9EC RID: 195052 RVA: 0x0067B421 File Offset: 0x00679621
		public static void StartLongPressProgressActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0602F9ED RID: 195053 RVA: 0x0067B42C File Offset: 0x0067962C
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(10, nullMask, 0);
		}

		// Token: 0x0602F9EE RID: 195054 RVA: 0x0067B438 File Offset: 0x00679638
		public static Offset<ILongPressInteractConfig> EndILongPressInteractConfig(FlatBufferBuilder builder)
		{
			return new Offset<ILongPressInteractConfig>(builder.EndTable());
		}

		// Token: 0x0602F9EF RID: 195055 RVA: 0x0067B448 File Offset: 0x00679648
		public ILongPressInteractConfigT UnPack()
		{
			ILongPressInteractConfigT longPressInteractConfigT = new ILongPressInteractConfigT();
			this.UnPackTo(longPressInteractConfigT);
			return longPressInteractConfigT;
		}

		// Token: 0x0602F9F0 RID: 195056 RVA: 0x0067B464 File Offset: 0x00679664
		public void UnPackTo(ILongPressInteractConfigT _o)
		{
			_o.PressDuration = this.PressDuration;
			_o.PressEffect = ((this.PressEffect != null) ? this.PressEffect.Value.UnPack() : null);
			_o.Style = new TLongPressInteractStyleConfigUnion();
			_o.Style.Type = this.StyleType;
			switch (this.StyleType)
			{
			case TLongPressInteractStyleConfig.ILongPressInteractStyleConfigDefault:
				_o.Style.Value = ((this.Style<ILongPressInteractStyleConfigDefault>() != null) ? this.Style<ILongPressInteractStyleConfigDefault>().Value.UnPack() : null);
				break;
			case TLongPressInteractStyleConfig.ILongPressInteractStyleConfigTimeBackInteract:
				_o.Style.Value = ((this.Style<ILongPressInteractStyleConfigTimeBackInteract>() != null) ? this.Style<ILongPressInteractStyleConfigTimeBackInteract>().Value.UnPack() : null);
				break;
			case TLongPressInteractStyleConfig.ILongPressInteractStyleCoreFix:
				_o.Style.Value = ((this.Style<ILongPressInteractStyleCoreFix>() != null) ? this.Style<ILongPressInteractStyleCoreFix>().Value.UnPack() : null);
				break;
			case TLongPressInteractStyleConfig.ILongPressInteractStyleSwordRider:
				_o.Style.Value = ((this.Style<ILongPressInteractStyleSwordRider>() != null) ? this.Style<ILongPressInteractStyleSwordRider>().Value.UnPack() : null);
				break;
			}
			_o.ResetFromCurrentProgress = this.ResetFromCurrentProgress;
			_o.LongPressButtonActionMapping = ((this.LongPressButtonActionMapping != null) ? this.LongPressButtonActionMapping.Value.UnPack() : null);
			_o.LongPressStartActions = new List<IActionInfoT>();
			for (int i = 0; i < this.LongPressStartActionsLength; i++)
			{
				_o.LongPressStartActions.Add((this.LongPressStartActions(i) != null) ? this.LongPressStartActions(i).Value.UnPack() : null);
			}
			_o.LongPressInterruptedActions = new List<IActionInfoT>();
			for (int j = 0; j < this.LongPressInterruptedActionsLength; j++)
			{
				_o.LongPressInterruptedActions.Add((this.LongPressInterruptedActions(j) != null) ? this.LongPressInterruptedActions(j).Value.UnPack() : null);
			}
			_o.LongPressSuccessActions = new List<IActionInfoT>();
			for (int k = 0; k < this.LongPressSuccessActionsLength; k++)
			{
				_o.LongPressSuccessActions.Add((this.LongPressSuccessActions(k) != null) ? this.LongPressSuccessActions(k).Value.UnPack() : null);
			}
			_o.LongPressProgressActions = new List<ILongPressProgressActionT>();
			for (int l = 0; l < this.LongPressProgressActionsLength; l++)
			{
				_o.LongPressProgressActions.Add((this.LongPressProgressActions(l) != null) ? this.LongPressProgressActions(l).Value.UnPack() : null);
			}
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0602F9F1 RID: 195057 RVA: 0x0067B788 File Offset: 0x00679988
		public static Offset<ILongPressInteractConfig> Pack(FlatBufferBuilder builder, ILongPressInteractConfigT _o)
		{
			if (_o == null)
			{
				return default(Offset<ILongPressInteractConfig>);
			}
			Offset<ILongPressEffectConfig> pressEffectOffset = (_o.PressEffect == null) ? default(Offset<ILongPressEffectConfig>) : ILongPressEffectConfig.Pack(builder, _o.PressEffect);
			TLongPressInteractStyleConfig style_type = (_o.Style == null) ? TLongPressInteractStyleConfig.NONE : _o.Style.Type;
			int styleOffset = (_o.Style == null) ? 0 : TLongPressInteractStyleConfigUnion.Pack(builder, _o.Style);
			Offset<ILongPressButtonActionMapping> longPressButtonActionMappingOffset = (_o.LongPressButtonActionMapping == null) ? default(Offset<ILongPressButtonActionMapping>) : ILongPressButtonActionMapping.Pack(builder, _o.LongPressButtonActionMapping);
			VectorOffset longPressStartActionsOffset = default(VectorOffset);
			if (_o.LongPressStartActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.LongPressStartActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.LongPressStartActions[i]);
				}
				longPressStartActionsOffset = ILongPressInteractConfig.CreateLongPressStartActionsVector(builder, array);
			}
			VectorOffset longPressInterruptedActionsOffset = default(VectorOffset);
			if (_o.LongPressInterruptedActions != null)
			{
				Offset<IActionInfo>[] array2 = new Offset<IActionInfo>[_o.LongPressInterruptedActions.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = IActionInfo.Pack(builder, _o.LongPressInterruptedActions[j]);
				}
				longPressInterruptedActionsOffset = ILongPressInteractConfig.CreateLongPressInterruptedActionsVector(builder, array2);
			}
			VectorOffset longPressSuccessActionsOffset = default(VectorOffset);
			if (_o.LongPressSuccessActions != null)
			{
				Offset<IActionInfo>[] array3 = new Offset<IActionInfo>[_o.LongPressSuccessActions.Count];
				for (int k = 0; k < array3.Length; k++)
				{
					array3[k] = IActionInfo.Pack(builder, _o.LongPressSuccessActions[k]);
				}
				longPressSuccessActionsOffset = ILongPressInteractConfig.CreateLongPressSuccessActionsVector(builder, array3);
			}
			VectorOffset longPressProgressActionsOffset = default(VectorOffset);
			if (_o.LongPressProgressActions != null)
			{
				Offset<ILongPressProgressAction>[] array4 = new Offset<ILongPressProgressAction>[_o.LongPressProgressActions.Count];
				for (int l = 0; l < array4.Length; l++)
				{
					array4[l] = ILongPressProgressAction.Pack(builder, _o.LongPressProgressActions[l]);
				}
				longPressProgressActionsOffset = ILongPressInteractConfig.CreateLongPressProgressActionsVector(builder, array4);
			}
			return ILongPressInteractConfig.CreateILongPressInteractConfig(builder, _o.PressDuration, pressEffectOffset, style_type, styleOffset, _o.ResetFromCurrentProgress, longPressButtonActionMappingOffset, longPressStartActionsOffset, longPressInterruptedActionsOffset, longPressSuccessActionsOffset, longPressProgressActionsOffset, _o.NullMask);
		}

		// Token: 0x04011251 RID: 70225
		private Table __p;
	}
}
