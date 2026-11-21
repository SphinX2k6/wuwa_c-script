using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02007A43 RID: 31299
	public struct ISwitchSubLevelsDirectly : IFlatbufferObject
	{
		// Token: 0x1700E54F RID: 58703
		// (get) Token: 0x0603727A RID: 225914 RVA: 0x0075E3F5 File Offset: 0x0075C5F5
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603727B RID: 225915 RVA: 0x0075E402 File Offset: 0x0075C602
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603727C RID: 225916 RVA: 0x0075E40C File Offset: 0x0075C60C
		public static ISwitchSubLevelsDirectly GetRootAsISwitchSubLevelsDirectly(ByteBuffer _bb)
		{
			return ISwitchSubLevelsDirectly.GetRootAsISwitchSubLevelsDirectly(_bb, default(ISwitchSubLevelsDirectly));
		}

		// Token: 0x0603727D RID: 225917 RVA: 0x0075E428 File Offset: 0x0075C628
		public static ISwitchSubLevelsDirectly GetRootAsISwitchSubLevelsDirectly(ByteBuffer _bb, ISwitchSubLevelsDirectly obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603727E RID: 225918 RVA: 0x0075E445 File Offset: 0x0075C645
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603727F RID: 225919 RVA: 0x0075E454 File Offset: 0x0075C654
		public ISwitchSubLevelsDirectly __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700E550 RID: 58704
		// (get) Token: 0x06037280 RID: 225920 RVA: 0x0075E464 File Offset: 0x0075C664
		public ESwitchSubLevelsType Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESwitchSubLevelsType.Directly;
				}
				return (ESwitchSubLevelsType)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06037281 RID: 225921 RVA: 0x0075E4A0 File Offset: 0x0075C6A0
		public string LoadLevels(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E551 RID: 58705
		// (get) Token: 0x06037282 RID: 225922 RVA: 0x0075E4DC File Offset: 0x0075C6DC
		public int LoadLevelsLength
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

		// Token: 0x06037283 RID: 225923 RVA: 0x0075E508 File Offset: 0x0075C708
		public string UnloadLevels(int j)
		{
			int num = this.__p.__offset(8);
			if (num == 0)
			{
				return null;
			}
			return this.__p.__string(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700E552 RID: 58706
		// (get) Token: 0x06037284 RID: 225924 RVA: 0x0075E544 File Offset: 0x0075C744
		public int UnloadLevelsLength
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

		// Token: 0x1700E553 RID: 58707
		// (get) Token: 0x06037285 RID: 225925 RVA: 0x0075E570 File Offset: 0x0075C770
		public int TeleportEntityId
		{
			get
			{
				int num = this.__p.__offset(10);
				if (num == 0)
				{
					return 0;
				}
				return this.__p.bb.GetInt(num + this.__p.bb_pos);
			}
		}

		// Token: 0x1700E554 RID: 58708
		// (get) Token: 0x06037286 RID: 225926 RVA: 0x0075E5B0 File Offset: 0x0075C7B0
		public bool IsWaitForSwitchComplete
		{
			get
			{
				int num = this.__p.__offset(12);
				return num != 0 && this.__p.bb.Get(num + this.__p.bb_pos) > 0;
			}
		}

		// Token: 0x1700E555 RID: 58709
		// (get) Token: 0x06037287 RID: 225927 RVA: 0x0075E5F0 File Offset: 0x0075C7F0
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

		// Token: 0x06037288 RID: 225928 RVA: 0x0075E62D File Offset: 0x0075C82D
		public static Offset<ISwitchSubLevelsDirectly> CreateISwitchSubLevelsDirectly(FlatBufferBuilder builder, ESwitchSubLevelsType Type = ESwitchSubLevelsType.Directly, VectorOffset LoadLevelsOffset = default(VectorOffset), VectorOffset UnloadLevelsOffset = default(VectorOffset), int TeleportEntityId = 0, bool IsWaitForSwitchComplete = false, byte NullMask = 0)
		{
			builder.StartTable(6);
			ISwitchSubLevelsDirectly.AddTeleportEntityId(builder, TeleportEntityId);
			ISwitchSubLevelsDirectly.AddUnloadLevels(builder, UnloadLevelsOffset);
			ISwitchSubLevelsDirectly.AddLoadLevels(builder, LoadLevelsOffset);
			ISwitchSubLevelsDirectly.AddNullMask(builder, NullMask);
			ISwitchSubLevelsDirectly.AddIsWaitForSwitchComplete(builder, IsWaitForSwitchComplete);
			ISwitchSubLevelsDirectly.AddType(builder, Type);
			return ISwitchSubLevelsDirectly.EndISwitchSubLevelsDirectly(builder);
		}

		// Token: 0x06037289 RID: 225929 RVA: 0x0075E669 File Offset: 0x0075C869
		public static void StartISwitchSubLevelsDirectly(FlatBufferBuilder builder)
		{
			builder.StartTable(6);
		}

		// Token: 0x0603728A RID: 225930 RVA: 0x0075E672 File Offset: 0x0075C872
		public static void AddType(FlatBufferBuilder builder, ESwitchSubLevelsType type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x0603728B RID: 225931 RVA: 0x0075E67D File Offset: 0x0075C87D
		public static void AddLoadLevels(FlatBufferBuilder builder, VectorOffset loadLevelsOffset)
		{
			builder.AddOffset(1, loadLevelsOffset.Value, 0);
		}

		// Token: 0x0603728C RID: 225932 RVA: 0x0075E690 File Offset: 0x0075C890
		public static VectorOffset CreateLoadLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x0603728D RID: 225933 RVA: 0x0075E6D0 File Offset: 0x0075C8D0
		public static VectorOffset CreateLoadLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603728E RID: 225934 RVA: 0x0075E6EA File Offset: 0x0075C8EA
		public static VectorOffset CreateLoadLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x0603728F RID: 225935 RVA: 0x0075E708 File Offset: 0x0075C908
		public static VectorOffset CreateLoadLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06037290 RID: 225936 RVA: 0x0075E721 File Offset: 0x0075C921
		public static void StartLoadLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06037291 RID: 225937 RVA: 0x0075E72C File Offset: 0x0075C92C
		public static void AddUnloadLevels(FlatBufferBuilder builder, VectorOffset unloadLevelsOffset)
		{
			builder.AddOffset(2, unloadLevelsOffset.Value, 0);
		}

		// Token: 0x06037292 RID: 225938 RVA: 0x0075E73C File Offset: 0x0075C93C
		public static VectorOffset CreateUnloadLevelsVector(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06037293 RID: 225939 RVA: 0x0075E77C File Offset: 0x0075C97C
		public static VectorOffset CreateUnloadLevelsVectorBlock(FlatBufferBuilder builder, StringOffset[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06037294 RID: 225940 RVA: 0x0075E796 File Offset: 0x0075C996
		public static VectorOffset CreateUnloadLevelsVectorBlock(FlatBufferBuilder builder, ArraySegment<StringOffset> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<StringOffset>(data);
			return builder.EndVector();
		}

		// Token: 0x06037295 RID: 225941 RVA: 0x0075E7B4 File Offset: 0x0075C9B4
		public static VectorOffset CreateUnloadLevelsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<StringOffset>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06037296 RID: 225942 RVA: 0x0075E7CD File Offset: 0x0075C9CD
		public static void StartUnloadLevelsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06037297 RID: 225943 RVA: 0x0075E7D8 File Offset: 0x0075C9D8
		public static void AddTeleportEntityId(FlatBufferBuilder builder, int teleportEntityId)
		{
			builder.AddInt(3, teleportEntityId, 0);
		}

		// Token: 0x06037298 RID: 225944 RVA: 0x0075E7E3 File Offset: 0x0075C9E3
		public static void AddIsWaitForSwitchComplete(FlatBufferBuilder builder, bool isWaitForSwitchComplete)
		{
			builder.AddBool(4, isWaitForSwitchComplete, false);
		}

		// Token: 0x06037299 RID: 225945 RVA: 0x0075E7EE File Offset: 0x0075C9EE
		public static void AddNullMask(FlatBufferBuilder builder, byte nullMask)
		{
			builder.AddByte(5, nullMask, 0);
		}

		// Token: 0x0603729A RID: 225946 RVA: 0x0075E7F9 File Offset: 0x0075C9F9
		public static Offset<ISwitchSubLevelsDirectly> EndISwitchSubLevelsDirectly(FlatBufferBuilder builder)
		{
			return new Offset<ISwitchSubLevelsDirectly>(builder.EndTable());
		}

		// Token: 0x0603729B RID: 225947 RVA: 0x0075E808 File Offset: 0x0075CA08
		public ISwitchSubLevelsDirectlyT UnPack()
		{
			ISwitchSubLevelsDirectlyT switchSubLevelsDirectlyT = new ISwitchSubLevelsDirectlyT();
			this.UnPackTo(switchSubLevelsDirectlyT);
			return switchSubLevelsDirectlyT;
		}

		// Token: 0x0603729C RID: 225948 RVA: 0x0075E824 File Offset: 0x0075CA24
		public void UnPackTo(ISwitchSubLevelsDirectlyT _o)
		{
			_o.Type = this.Type;
			_o.LoadLevels = new List<string>();
			for (int i = 0; i < this.LoadLevelsLength; i++)
			{
				_o.LoadLevels.Add(this.LoadLevels(i));
			}
			_o.UnloadLevels = new List<string>();
			for (int j = 0; j < this.UnloadLevelsLength; j++)
			{
				_o.UnloadLevels.Add(this.UnloadLevels(j));
			}
			_o.TeleportEntityId = this.TeleportEntityId;
			_o.IsWaitForSwitchComplete = this.IsWaitForSwitchComplete;
			_o.NullMask = this.NullMask;
		}

		// Token: 0x0603729D RID: 225949 RVA: 0x0075E8C0 File Offset: 0x0075CAC0
		public static Offset<ISwitchSubLevelsDirectly> Pack(FlatBufferBuilder builder, ISwitchSubLevelsDirectlyT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISwitchSubLevelsDirectly>);
			}
			VectorOffset loadLevelsOffset = default(VectorOffset);
			if (_o.LoadLevels != null)
			{
				StringOffset[] array = new StringOffset[_o.LoadLevels.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = builder.CreateString(_o.LoadLevels[i]);
				}
				loadLevelsOffset = ISwitchSubLevelsDirectly.CreateLoadLevelsVector(builder, array);
			}
			VectorOffset unloadLevelsOffset = default(VectorOffset);
			if (_o.UnloadLevels != null)
			{
				StringOffset[] array2 = new StringOffset[_o.UnloadLevels.Count];
				for (int j = 0; j < array2.Length; j++)
				{
					array2[j] = builder.CreateString(_o.UnloadLevels[j]);
				}
				unloadLevelsOffset = ISwitchSubLevelsDirectly.CreateUnloadLevelsVector(builder, array2);
			}
			return ISwitchSubLevelsDirectly.CreateISwitchSubLevelsDirectly(builder, _o.Type, loadLevelsOffset, unloadLevelsOffset, _o.TeleportEntityId, _o.IsWaitForSwitchComplete, _o.NullMask);
		}

		// Token: 0x04012D6D RID: 77165
		private Table __p;
	}
}
