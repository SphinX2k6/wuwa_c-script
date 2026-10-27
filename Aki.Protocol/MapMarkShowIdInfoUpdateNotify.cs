using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200098E RID: 2446
	[NetMessage(EMessageId.MapMarkShowIdInfoUpdateNotify)]
	public sealed class MapMarkShowIdInfoUpdateNotify : IMessage<MapMarkShowIdInfoUpdateNotify>, IMessage, IEquatable<MapMarkShowIdInfoUpdateNotify>, IDeepCloneable<MapMarkShowIdInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0600D6FE RID: 55038 RVA: 0x001F9E97 File Offset: 0x001F8097
		[NullableContext(1)]
		public static MapMarkShowIdInfoUpdateNotify Create()
		{
			return new MapMarkShowIdInfoUpdateNotify();
		}

		// Token: 0x17002B88 RID: 11144
		// (get) Token: 0x0600D6FF RID: 55039 RVA: 0x001F9E9E File Offset: 0x001F809E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002B89 RID: 11145
		// (get) Token: 0x0600D700 RID: 55040 RVA: 0x001F9EA1 File Offset: 0x001F80A1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return MapMarkShowIdInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0600D701 RID: 55041 RVA: 0x001F9EA8 File Offset: 0x001F80A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowIdInfoUpdateNotify()
		{
		}

		// Token: 0x0600D702 RID: 55042 RVA: 0x001F9EB0 File Offset: 0x001F80B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowIdInfoUpdateNotify(MapMarkShowIdInfoUpdateNotify other) : this()
		{
			this.markId_ = other.markId_;
			this.isShow_ = other.isShow_;
			this.needFocus_ = other.needFocus_;
			this.showFlag_ = other.showFlag_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600D703 RID: 55043 RVA: 0x001F9F04 File Offset: 0x001F8104
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public MapMarkShowIdInfoUpdateNotify Clone()
		{
			return new MapMarkShowIdInfoUpdateNotify(this);
		}

		// Token: 0x17002B8A RID: 11146
		// (get) Token: 0x0600D704 RID: 55044 RVA: 0x001F9F0C File Offset: 0x001F810C
		// (set) Token: 0x0600D705 RID: 55045 RVA: 0x001F9F14 File Offset: 0x001F8114
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MarkId
		{
			get
			{
				return this.markId_;
			}
			set
			{
				this.markId_ = value;
			}
		}

		// Token: 0x17002B8B RID: 11147
		// (get) Token: 0x0600D706 RID: 55046 RVA: 0x001F9F1D File Offset: 0x001F811D
		// (set) Token: 0x0600D707 RID: 55047 RVA: 0x001F9F25 File Offset: 0x001F8125
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool IsShow
		{
			get
			{
				return this.isShow_;
			}
			set
			{
				this.isShow_ = value;
			}
		}

		// Token: 0x17002B8C RID: 11148
		// (get) Token: 0x0600D708 RID: 55048 RVA: 0x001F9F2E File Offset: 0x001F812E
		// (set) Token: 0x0600D709 RID: 55049 RVA: 0x001F9F36 File Offset: 0x001F8136
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool NeedFocus
		{
			get
			{
				return this.needFocus_;
			}
			set
			{
				this.needFocus_ = value;
			}
		}

		// Token: 0x17002B8D RID: 11149
		// (get) Token: 0x0600D70A RID: 55050 RVA: 0x001F9F3F File Offset: 0x001F813F
		// (set) Token: 0x0600D70B RID: 55051 RVA: 0x001F9F47 File Offset: 0x001F8147
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public uint ShowFlag
		{
			get
			{
				return this.showFlag_;
			}
			set
			{
				this.showFlag_ = value;
			}
		}

		// Token: 0x0600D70C RID: 55052 RVA: 0x001F9F50 File Offset: 0x001F8150
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as MapMarkShowIdInfoUpdateNotify);
		}

		// Token: 0x0600D70D RID: 55053 RVA: 0x001F9F60 File Offset: 0x001F8160
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(MapMarkShowIdInfoUpdateNotify other)
		{
			return other != null && (other == this || (this.MarkId == other.MarkId && this.IsShow == other.IsShow && this.NeedFocus == other.NeedFocus && this.ShowFlag == other.ShowFlag && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600D70E RID: 55054 RVA: 0x001F9FCC File Offset: 0x001F81CC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.MarkId != 0)
			{
				num ^= this.MarkId.GetHashCode();
			}
			if (this.IsShow)
			{
				num ^= this.IsShow.GetHashCode();
			}
			if (this.NeedFocus)
			{
				num ^= this.NeedFocus.GetHashCode();
			}
			if (this.ShowFlag != 0U)
			{
				num ^= this.ShowFlag.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600D70F RID: 55055 RVA: 0x001FA056 File Offset: 0x001F8256
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600D710 RID: 55056 RVA: 0x001FA063 File Offset: 0x001F8263
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600D711 RID: 55057 RVA: 0x001FA06C File Offset: 0x001F826C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.IsShow)
			{
				output.WriteRawTag(56);
				output.WriteBool(this.IsShow);
			}
			if (this.ShowFlag != 0U)
			{
				output.WriteRawTag(72);
				output.WriteUInt32(this.ShowFlag);
			}
			if (this.NeedFocus)
			{
				output.WriteRawTag(104);
				output.WriteBool(this.NeedFocus);
			}
			if (this.MarkId != 0)
			{
				output.WriteRawTag(120);
				output.WriteInt32(this.MarkId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600D712 RID: 55058 RVA: 0x001FA100 File Offset: 0x001F8300
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.MarkId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MarkId);
			}
			if (this.IsShow)
			{
				num += 2;
			}
			if (this.NeedFocus)
			{
				num += 2;
			}
			if (this.ShowFlag != 0U)
			{
				num += 1 + CodedOutputStream.ComputeUInt32Size(this.ShowFlag);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600D713 RID: 55059 RVA: 0x001FA170 File Offset: 0x001F8370
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(MapMarkShowIdInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.MarkId != 0)
			{
				this.MarkId = other.MarkId;
			}
			if (other.IsShow)
			{
				this.IsShow = other.IsShow;
			}
			if (other.NeedFocus)
			{
				this.NeedFocus = other.NeedFocus;
			}
			if (other.ShowFlag != 0U)
			{
				this.ShowFlag = other.ShowFlag;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600D714 RID: 55060 RVA: 0x001FA1E8 File Offset: 0x001F83E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600D715 RID: 55061 RVA: 0x001FA1F4 File Offset: 0x001F83F4
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
				if (num <= 72U)
				{
					if (num == 56U)
					{
						this.IsShow = input.ReadBool();
						continue;
					}
					if (num == 72U)
					{
						this.ShowFlag = input.ReadUInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.NeedFocus = input.ReadBool();
						continue;
					}
					if (num == 120U)
					{
						this.MarkId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040059CD RID: 22989
		private UnknownFieldSet _unknownFields;

		// Token: 0x040059CE RID: 22990
		public const int MarkIdFieldNumber = 15;

		// Token: 0x040059CF RID: 22991
		private int markId_;

		// Token: 0x040059D0 RID: 22992
		public const int IsShowFieldNumber = 7;

		// Token: 0x040059D1 RID: 22993
		private bool isShow_;

		// Token: 0x040059D2 RID: 22994
		public const int NeedFocusFieldNumber = 13;

		// Token: 0x040059D3 RID: 22995
		private bool needFocus_;

		// Token: 0x040059D4 RID: 22996
		public const int ShowFlagFieldNumber = 9;

		// Token: 0x040059D5 RID: 22997
		private uint showFlag_;
	}
}
