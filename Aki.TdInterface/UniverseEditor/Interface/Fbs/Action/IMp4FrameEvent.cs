using System;
using System.Collections.Generic;
using Google.FlatBuffers;

namespace Aki.UniverseEditor.Interface.Fbs.Action
{
	// Token: 0x02006B7C RID: 27516
	public struct IMp4FrameEvent : IFlatbufferObject
	{
		// Token: 0x1700CC86 RID: 52358
		// (get) Token: 0x06030517 RID: 197911 RVA: 0x006909A0 File Offset: 0x0068EBA0
		public ByteBuffer ByteBuffer
		{
			get
			{
				return this.__p.bb;
			}
		}

		// Token: 0x06030518 RID: 197912 RVA: 0x006909AD File Offset: 0x0068EBAD
		public static void ValidateVersion()
		{
			FlatBufferConstants.FLATBUFFERS_25_2_10();
		}

		// Token: 0x06030519 RID: 197913 RVA: 0x006909B4 File Offset: 0x0068EBB4
		public static IMp4FrameEvent GetRootAsIMp4FrameEvent(ByteBuffer _bb)
		{
			return IMp4FrameEvent.GetRootAsIMp4FrameEvent(_bb, default(IMp4FrameEvent));
		}

		// Token: 0x0603051A RID: 197914 RVA: 0x006909D0 File Offset: 0x0068EBD0
		public static IMp4FrameEvent GetRootAsIMp4FrameEvent(ByteBuffer _bb, IMp4FrameEvent obj)
		{
			return obj.__assign(_bb.GetInt(_bb.Position) + _bb.Position, _bb);
		}

		// Token: 0x0603051B RID: 197915 RVA: 0x006909ED File Offset: 0x0068EBED
		public void __init(int _i, ByteBuffer _bb)
		{
			this.__p = new Table(_i, _bb);
		}

		// Token: 0x0603051C RID: 197916 RVA: 0x006909FC File Offset: 0x0068EBFC
		public IMp4FrameEvent __assign(int _i, ByteBuffer _bb)
		{
			this.__init(_i, _bb);
			return this;
		}

		// Token: 0x1700CC87 RID: 52359
		// (get) Token: 0x0603051D RID: 197917 RVA: 0x00690A0C File Offset: 0x0068EC0C
		public float Second
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

		// Token: 0x0603051E RID: 197918 RVA: 0x00690A4C File Offset: 0x0068EC4C
		public IActionInfo? EventActions(int j)
		{
			int num = this.__p.__offset(6);
			if (num == 0)
			{
				return null;
			}
			return new IActionInfo?(default(IActionInfo).__assign(this.__p.__indirect(this.__p.__vector(num) + j * 4), this.__p.bb));
		}

		// Token: 0x1700CC88 RID: 52360
		// (get) Token: 0x0603051F RID: 197919 RVA: 0x00690AAC File Offset: 0x0068ECAC
		public int EventActionsLength
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

		// Token: 0x06030520 RID: 197920 RVA: 0x00690AD7 File Offset: 0x0068ECD7
		public static Offset<IMp4FrameEvent> CreateIMp4FrameEvent(FlatBufferBuilder builder, float Second = 0f, VectorOffset EventActionsOffset = default(VectorOffset))
		{
			builder.StartTable(2);
			IMp4FrameEvent.AddEventActions(builder, EventActionsOffset);
			IMp4FrameEvent.AddSecond(builder, Second);
			return IMp4FrameEvent.EndIMp4FrameEvent(builder);
		}

		// Token: 0x06030521 RID: 197921 RVA: 0x00690AF4 File Offset: 0x0068ECF4
		public static void StartIMp4FrameEvent(FlatBufferBuilder builder)
		{
			builder.StartTable(2);
		}

		// Token: 0x06030522 RID: 197922 RVA: 0x00690AFD File Offset: 0x0068ECFD
		public static void AddSecond(FlatBufferBuilder builder, float second)
		{
			builder.AddFloat(0, second, 0.0);
		}

		// Token: 0x06030523 RID: 197923 RVA: 0x00690B10 File Offset: 0x0068ED10
		public static void AddEventActions(FlatBufferBuilder builder, VectorOffset eventActionsOffset)
		{
			builder.AddOffset(1, eventActionsOffset.Value, 0);
		}

		// Token: 0x06030524 RID: 197924 RVA: 0x00690B20 File Offset: 0x0068ED20
		public static VectorOffset CreateEventActionsVector(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			for (int i = data.Length - 1; i >= 0; i--)
			{
				builder.AddOffset(data[i].Value);
			}
			return builder.EndVector();
		}

		// Token: 0x06030525 RID: 197925 RVA: 0x00690B60 File Offset: 0x0068ED60
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, Offset<IActionInfo>[] data)
		{
			builder.StartVector(4, data.Length, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030526 RID: 197926 RVA: 0x00690B7A File Offset: 0x0068ED7A
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, ArraySegment<Offset<IActionInfo>> data)
		{
			builder.StartVector(4, data.Count, 4);
			builder.Add<Offset<IActionInfo>>(data);
			return builder.EndVector();
		}

		// Token: 0x06030527 RID: 197927 RVA: 0x00690B98 File Offset: 0x0068ED98
		public static VectorOffset CreateEventActionsVectorBlock(FlatBufferBuilder builder, IntPtr dataPtr, int sizeInBytes)
		{
			builder.StartVector(1, sizeInBytes, 1);
			builder.Add<Offset<IActionInfo>>(dataPtr, sizeInBytes);
			return builder.EndVector();
		}

		// Token: 0x06030528 RID: 197928 RVA: 0x00690BB1 File Offset: 0x0068EDB1
		public static void StartEventActionsVector(FlatBufferBuilder builder, int numElems)
		{
			builder.StartVector(4, numElems, 4);
		}

		// Token: 0x06030529 RID: 197929 RVA: 0x00690BBC File Offset: 0x0068EDBC
		public static Offset<IMp4FrameEvent> EndIMp4FrameEvent(FlatBufferBuilder builder)
		{
			return new Offset<IMp4FrameEvent>(builder.EndTable());
		}

		// Token: 0x0603052A RID: 197930 RVA: 0x00690BCC File Offset: 0x0068EDCC
		public IMp4FrameEventT UnPack()
		{
			IMp4FrameEventT mp4FrameEventT = new IMp4FrameEventT();
			this.UnPackTo(mp4FrameEventT);
			return mp4FrameEventT;
		}

		// Token: 0x0603052B RID: 197931 RVA: 0x00690BE8 File Offset: 0x0068EDE8
		public void UnPackTo(IMp4FrameEventT _o)
		{
			_o.Second = this.Second;
			_o.EventActions = new List<IActionInfoT>();
			for (int i = 0; i < this.EventActionsLength; i++)
			{
				_o.EventActions.Add((this.EventActions(i) != null) ? this.EventActions(i).Value.UnPack() : null);
			}
		}

		// Token: 0x0603052C RID: 197932 RVA: 0x00690C54 File Offset: 0x0068EE54
		public static Offset<IMp4FrameEvent> Pack(FlatBufferBuilder builder, IMp4FrameEventT _o)
		{
			if (_o == null)
			{
				return default(Offset<IMp4FrameEvent>);
			}
			VectorOffset eventActionsOffset = default(VectorOffset);
			if (_o.EventActions != null)
			{
				Offset<IActionInfo>[] array = new Offset<IActionInfo>[_o.EventActions.Count];
				for (int i = 0; i < array.Length; i++)
				{
					array[i] = IActionInfo.Pack(builder, _o.EventActions[i]);
				}
				eventActionsOffset = IMp4FrameEvent.CreateEventActionsVector(builder, array);
			}
			return IMp4FrameEvent.CreateIMp4FrameEvent(builder, _o.Second, eventActionsOffset);
		}

		// Token: 0x04011437 RID: 70711
		private Table __p;
	}
}
