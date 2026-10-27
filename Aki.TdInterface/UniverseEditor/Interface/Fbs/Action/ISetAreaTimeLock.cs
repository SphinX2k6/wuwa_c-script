using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006FA8 RID: 28584
	public struct ISetAreaTimeLock : IFlatbufferObject
	{
		// Token: 0x1700D443 RID: 54339
		// (get) Token: 0x06032839 RID: 206905 RVA: 0x006D13D4 File Offset: 0x006CF5D4
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x0603283A RID: 206906 RVA: 0x006D13E1 File Offset: 0x006CF5E1
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x0603283B RID: 206907 RVA: 0x006D13E8 File Offset: 0x006CF5E8
		public static ISetAreaTimeLock GetRootAsISetAreaTimeLock(ByteBuffer _bb)
		{
			return ISetAreaTimeLock.GetRootAsISetAreaTimeLock(_bb, default(ISetAreaTimeLock));
		}

		// Token: 0x0603283C RID: 206908 RVA: 0x006D1404 File Offset: 0x006CF604
		public static ISetAreaTimeLock GetRootAsISetAreaTimeLock(ByteBuffer _bb, ISetAreaTimeLock obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603283D RID: 206909 RVA: 0x006D1421 File Offset: 0x006CF621
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603283E RID: 206910 RVA: 0x006D1430 File Offset: 0x006CF630
		public ISetAreaTimeLock __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700D444 RID: 54340
		// (get) Token: 0x0603283F RID: 206911 RVA: 0x006D1440 File Offset: 0x006CF640
		public ESetAreaTime Type
		{
			get
			{
				int num = this.__p.__offset(4);
				if (num == 0)
				{
					return ESetAreaTime.Lock;
				}
				return (ESetAreaTime)this.__p.bb.Get(num + this.__p.bb_pos);
			}
		}

		// Token: 0x06032840 RID: 206912 RVA: 0x006D147C File Offset: 0x006CF67C
		public int AreaIds(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return 0;
			}
			return this.__p.bb.GetInt(this.__p.__vector(num) + j * 4);
		}

		// Token: 0x1700D445 RID: 54341
		// (get) Token: 0x06032841 RID: 206913 RVA: 0x006D14BC File Offset: 0x006CF6BC
		public int AreaIdsLength
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

		// Token: 0x06032842 RID: 206914 RVA: 0x006D14E7 File Offset: 0x006CF6E7
		public Span<int> GetAreaIdsBytes()
		{
			return this.__p.__vector_as_span<int>(6, 4);
		}

		// Token: 0x06032843 RID: 206915 RVA: 0x006D14F6 File Offset: 0x006CF6F6
		public int[] GetAreaIdsArray()
		{
			return this.__p.__vector_as_array<int>(6);
		}

		// Token: 0x1700D446 RID: 54342
		// (get) Token: 0x06032844 RID: 206916 RVA: 0x006D1504 File Offset: 0x006CF704
		public IFixedTime? LockTime
		{
			get
			{
				int num = this.__p.__offset(8);
				if (num == 0)
				{
					return null;
				}
				return new IFixedTime?(default(IFixedTime).__assign(this.__p.__indirect(num + this.__p.bb_pos), this.__p.bb));
			}
		}

		// Token: 0x06032845 RID: 206917 RVA: 0x006D1561 File Offset: 0x006CF761
		public static Offset<ISetAreaTimeLock> CreateISetAreaTimeLock(FlatBufferBuilder builder, ESetAreaTime Type = ESetAreaTime.Lock, VectorOffset AreaIdsOffset = default(VectorOffset), Offset<IFixedTime> LockTimeOffset = default(Offset<IFixedTime>))
		{
			builder.StartTable(3);
			ISetAreaTimeLock.AddLockTime(builder, LockTimeOffset);
			ISetAreaTimeLock.AddAreaIds(builder, AreaIdsOffset);
			ISetAreaTimeLock.AddType(builder, Type);
			return ISetAreaTimeLock.EndISetAreaTimeLock(builder);
		}

		// Token: 0x06032846 RID: 206918 RVA: 0x006D1585 File Offset: 0x006CF785
		public static void StartISetAreaTimeLock(FlatBufferBuilder builder)
		{
			builder.StartTable(3);
		}

		// Token: 0x06032847 RID: 206919 RVA: 0x006D158E File Offset: 0x006CF78E
		public static void AddType(FlatBufferBuilder builder, ESetAreaTime type)
		{
			builder.AddByte(0, (byte)type, 0);
		}

		// Token: 0x06032848 RID: 206920 RVA: 0x006D1599 File Offset: 0x006CF799
		public static void AddAreaIds(FlatBufferBuilder builder, VectorOffset areaIdsOffset)
		{
			builder.AddOffset(1, areaIdsOffset.Value, 0);
		}

		// Token: 0x06032849 RID: 206921 RVA: 0x006D15AC File Offset: 0x006CF7AC
		public static VectorOffset CreateAreaIdsVector(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddInt(data[i]);
			}
			return builder.EndVector();
		}

		// Token: 0x0603284A RID: 206922 RVA: 0x006D15E3 File Offset: 0x006CF7E3
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, int[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603284B RID: 206923 RVA: 0x006D15FD File Offset: 0x006CF7FD
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, ArraySegment<int> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<int>(data);
			return builder.EndVector();
		}

		// Token: 0x0603284C RID: 206924 RVA: 0x006D161B File Offset: 0x006CF81B
		public static VectorOffset CreateAreaIdsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<int>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x0603284D RID: 206925 RVA: 0x006D1634 File Offset: 0x006CF834
		public static void StartAreaIdsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x0603284E RID: 206926 RVA: 0x006D163F File Offset: 0x006CF83F
		public static void AddLockTime(FlatBufferBuilder builder, Offset<IFixedTime> lockTimeOffset)
		{
			builder.AddOffset(2, lockTimeOffset.Value, 0);
		}

		// Token: 0x0603284F RID: 206927 RVA: 0x006D164F File Offset: 0x006CF84F
		public static Offset<ISetAreaTimeLock> EndISetAreaTimeLock(FlatBufferBuilder builder)
		{
			return new Offset<ISetAreaTimeLock>(builder.EndTable());
		}

		// Token: 0x06032850 RID: 206928 RVA: 0x006D165C File Offset: 0x006CF85C
		public ISetAreaTimeLockT UnPack()
		{
			ISetAreaTimeLockT setAreaTimeLockT = new ISetAreaTimeLockT();
			this.UnPackTo(setAreaTimeLockT);
			return setAreaTimeLockT;
		}

		// Token: 0x06032851 RID: 206929 RVA: 0x006D1678 File Offset: 0x006CF878
		public void UnPackTo(ISetAreaTimeLockT _o)
		{
			_o.Type = this.Type;
			_o.AreaIds = new List<int>();
			for (int i = 0; i < this.AreaIdsLength; i++)
			{
				_o.AreaIds.Add(this.AreaIds(i));
			}
			_o.LockTime = ((this.LockTime != null) ? this.LockTime.Value.UnPack() : null);
		}

		// Token: 0x06032852 RID: 206930 RVA: 0x006D16F0 File Offset: 0x006CF8F0
		public static Offset<ISetAreaTimeLock> Pack(FlatBufferBuilder builder, ISetAreaTimeLockT _o)
		{
			if (_o == null)
			{
				return default(Offset<ISetAreaTimeLock>);
			}
			VectorOffset areaIdsOffset = default(VectorOffset);
			if (_o.AreaIds != null)
			{
				int[] data = _o.AreaIds.ToArray();
				areaIdsOffset = ISetAreaTimeLock.CreateAreaIdsVector(builder, data);
			}
			Offset<IFixedTime> lockTimeOffset = (_o.LockTime == null) ? default(Offset<IFixedTime>) : IFixedTime.Pack(builder, _o.LockTime);
			return ISetAreaTimeLock.CreateISetAreaTimeLock(builder, _o.Type, areaIdsOffset, lockTimeOffset);
		}

		// Token: 0x040119AF RID: 72111
		private Table __p;
	}
}
