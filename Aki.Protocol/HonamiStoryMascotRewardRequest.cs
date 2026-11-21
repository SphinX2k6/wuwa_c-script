using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200077B RID: 1915
	[NetMessage(EMessageId.HonamiStoryMascotRewardRequest)]
	public sealed class HonamiStoryMascotRewardRequest : IMessage<HonamiStoryMascotRewardRequest>, IMessage, IEquatable<HonamiStoryMascotRewardRequest>, IDeepCloneable<HonamiStoryMascotRewardRequest>, IBufferMessage
	{
		// Token: 0x0600AD5F RID: 44383 RVA: 0x001A10A9 File Offset: 0x0019F2A9
		[NullableContext(1)]
		public static HonamiStoryMascotRewardRequest Create()
		{
			return new HonamiStoryMascotRewardRequest();
		}

		// Token: 0x170022F7 RID: 8951
		// (get) Token: 0x0600AD60 RID: 44384 RVA: 0x001A10B0 File Offset: 0x0019F2B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170022F8 RID: 8952
		// (get) Token: 0x0600AD61 RID: 44385 RVA: 0x001A10B3 File Offset: 0x0019F2B3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryMascotRewardRequest.Descriptor;
			}
		}

		// Token: 0x0600AD62 RID: 44386 RVA: 0x001A10BA File Offset: 0x0019F2BA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardRequest()
		{
		}

		// Token: 0x0600AD63 RID: 44387 RVA: 0x001A10C2 File Offset: 0x0019F2C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardRequest(HonamiStoryMascotRewardRequest other) : this()
		{
			this.honamiStoryMascotId_ = other.honamiStoryMascotId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600AD64 RID: 44388 RVA: 0x001A10E7 File Offset: 0x0019F2E7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryMascotRewardRequest Clone()
		{
			return new HonamiStoryMascotRewardRequest(this);
		}

		// Token: 0x170022F9 RID: 8953
		// (get) Token: 0x0600AD65 RID: 44389 RVA: 0x001A10EF File Offset: 0x0019F2EF
		// (set) Token: 0x0600AD66 RID: 44390 RVA: 0x001A10F7 File Offset: 0x0019F2F7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HonamiStoryMascotId
		{
			get
			{
				return this.honamiStoryMascotId_;
			}
			set
			{
				this.honamiStoryMascotId_ = value;
			}
		}

		// Token: 0x0600AD67 RID: 44391 RVA: 0x001A1100 File Offset: 0x0019F300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryMascotRewardRequest);
		}

		// Token: 0x0600AD68 RID: 44392 RVA: 0x001A110E File Offset: 0x0019F30E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryMascotRewardRequest other)
		{
			return other != null && (other == this || (this.HonamiStoryMascotId == other.HonamiStoryMascotId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600AD69 RID: 44393 RVA: 0x001A113C File Offset: 0x0019F33C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HonamiStoryMascotId != 0)
			{
				num ^= this.HonamiStoryMascotId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600AD6A RID: 44394 RVA: 0x001A117B File Offset: 0x0019F37B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600AD6B RID: 44395 RVA: 0x001A1188 File Offset: 0x0019F388
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600AD6C RID: 44396 RVA: 0x001A1191 File Offset: 0x0019F391
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HonamiStoryMascotId != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.HonamiStoryMascotId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600AD6D RID: 44397 RVA: 0x001A11C4 File Offset: 0x0019F3C4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HonamiStoryMascotId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HonamiStoryMascotId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600AD6E RID: 44398 RVA: 0x001A1202 File Offset: 0x0019F402
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryMascotRewardRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HonamiStoryMascotId != 0)
			{
				this.HonamiStoryMascotId = other.HonamiStoryMascotId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600AD6F RID: 44399 RVA: 0x001A1233 File Offset: 0x0019F433
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600AD70 RID: 44400 RVA: 0x001A123C File Offset: 0x0019F43C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalMergeFrom(ref ParseContext input)
		{
			uint num;
			while ((num = input.ReadTag()) != 0U)
			{
				if ((num & 7U) == 4U)
				{
					return;
				}
				if (num != 112U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.HonamiStoryMascotId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004EC8 RID: 20168
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004EC9 RID: 20169
		public const int HonamiStoryMascotIdFieldNumber = 14;

		// Token: 0x04004ECA RID: 20170
		private int honamiStoryMascotId_;
	}
}
