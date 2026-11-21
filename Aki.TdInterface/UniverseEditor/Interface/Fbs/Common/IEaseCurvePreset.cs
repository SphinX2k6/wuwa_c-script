using System;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Common
{
	// Token: 0x020063D4 RID: 25556
	public struct IEaseCurvePreset : IFlatbufferObject
	{
		// Token: 0x1700BCD7 RID: 48343
		// (get) Token: 0x0602B696 RID: 177814 RVA: 0x005EA859 File Offset: 0x005E8A59
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0602B697 RID: 177815 RVA: 0x005EA866 File Offset: 0x005E8A66
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0602B698 RID: 177816 RVA: 0x005EA870 File Offset: 0x005E8A70
		public static IEaseCurvePreset GetRootAsIEaseCurvePreset(ByteBuffer _bb)
		{
			return IEaseCurvePreset.GetRootAsIEaseCurvePreset(_bb, default(IEaseCurvePreset));
		}

		// Token: 0x0602B699 RID: 177817 RVA: 0x005EA88C File Offset: 0x005E8A8C
		public static IEaseCurvePreset GetRootAsIEaseCurvePreset(ByteBuffer _bb, IEaseCurvePreset obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0602B69A RID: 177818 RVA: 0x005EA8A9 File Offset: 0x005E8AA9
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0602B69B RID: 177819 RVA: 0x005EA8B8 File Offset: 0x005E8AB8
		public IEaseCurvePreset __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700BCD8 RID: 48344
		// (get) Token: 0x0602B69C RID: 177820 RVA: 0x005EA8C8 File Offset: 0x005E8AC8
		public EEaseCurveType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return EEaseCurveType.Preset;
				}
				return (EEaseCurveType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700BCD9 RID: 48345
		// (get) Token: 0x0602B69D RID: 177821 RVA: 0x005EA904 File Offset: 0x005E8B04
		public EPresetEaseType PresetType
		{
			get
			{
				int num = this.__p.__offset(6);
				if (num == 0)
				{
					return EPresetEaseType.Linear;
				}
				return (EPresetEaseType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x0602B69E RID: 177822 RVA: 0x005EA940 File Offset: 0x005E8B40
		public static Offset<IEaseCurvePreset> CreateIEaseCurvePreset(FlatBufferBuilder builder, EEaseCurveType Type = EEaseCurveType.Preset, EPresetEaseType PresetType = EPresetEaseType.Linear)
		{
			builder.StartTable(2);
			IEaseCurvePreset.AddPresetType(builder, PresetType);
			IEaseCurvePreset.AddType(builder, Type);
			return IEaseCurvePreset.EndIEaseCurvePreset(builder);
		}

		// Token: 0x0602B69F RID: 177823 RVA: 0x005EA95D File Offset: 0x005E8B5D
		public static void StartIEaseCurvePreset(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x0602B6A0 RID: 177824 RVA: 0x005EA966 File Offset: 0x005E8B66
		public static void AddType(FlatBufferBuilder builder, EEaseCurveType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0602B6A1 RID: 177825 RVA: 0x005EA971 File Offset: 0x005E8B71
		public static void AddPresetType(FlatBufferBuilder builder, EPresetEaseType presetType)
		{
			builder.AddByte(1, (byte)presetType, 0);
		}

		// Token: 0x0602B6A2 RID: 177826 RVA: 0x005EA97C File Offset: 0x005E8B7C
		public static Offset<IEaseCurvePreset> EndIEaseCurvePreset(FlatBufferBuilder builder)
		{
			return new Offset<IEaseCurvePreset>(builder.EndTable());
		}

		// Token: 0x0602B6A3 RID: 177827 RVA: 0x005EA98C File Offset: 0x005E8B8C
		public IEaseCurvePresetT UnPack()
		{
			IEaseCurvePresetT easeCurvePresetT = new IEaseCurvePresetT();
			this.UnPackTo(easeCurvePresetT);
			return easeCurvePresetT;
		}

		// Token: 0x0602B6A4 RID: 177828 RVA: 0x005EA9A7 File Offset: 0x005E8BA7
		public void UnPackTo(IEaseCurvePresetT _o)
		{
			_o.Type = this.Type;
			_o.PresetType = this.PresetType;
		}

		// Token: 0x0602B6A5 RID: 177829 RVA: 0x005EA9C4 File Offset: 0x005E8BC4
		public static Offset<IEaseCurvePreset> Pack(FlatBufferBuilder builder, IEaseCurvePresetT _o)
		{
			if (_o == null)
			{
				return default(Offset<IEaseCurvePreset>);
			}
			return IEaseCurvePreset.CreateIEaseCurvePreset(builder, _o.Type, _o.PresetType);
		}

		// Token: 0x040104C6 RID: 66758
		private Table __p;
	}
}
