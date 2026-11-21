using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001412 RID: 5138
	[NetMessage(EMessageId.TowerDefenceInfoUpdateNotify)]
	public sealed class TowerDefenceInfoUpdateNotify : IMessage<TowerDefenceInfoUpdateNotify>, IMessage, IEquatable<TowerDefenceInfoUpdateNotify>, IDeepCloneable<TowerDefenceInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601B4FB RID: 111867 RVA: 0x003F8D81 File Offset: 0x003F6F81
		[NullableContext(1)]
		public static TowerDefenceInfoUpdateNotify Create()
		{
			return new TowerDefenceInfoUpdateNotify();
		}

		// Token: 0x17005C73 RID: 23667
		// (get) Token: 0x0601B4FC RID: 111868 RVA: 0x003F8D88 File Offset: 0x003F6F88
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005C74 RID: 23668
		// (get) Token: 0x0601B4FD RID: 111869 RVA: 0x003F8D8B File Offset: 0x003F6F8B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601B4FE RID: 111870 RVA: 0x003F8D92 File Offset: 0x003F6F92
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInfoUpdateNotify()
		{
		}

		// Token: 0x0601B4FF RID: 111871 RVA: 0x003F8D9A File Offset: 0x003F6F9A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInfoUpdateNotify(TowerDefenceInfoUpdateNotify other) : this()
		{
			this.activityInfo_ = ((other.activityInfo_ != null) ? other.activityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B500 RID: 111872 RVA: 0x003F8DCF File Offset: 0x003F6FCF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInfoUpdateNotify Clone()
		{
			return new TowerDefenceInfoUpdateNotify(this);
		}

		// Token: 0x17005C75 RID: 23669
		// (get) Token: 0x0601B501 RID: 111873 RVA: 0x003F8DD7 File Offset: 0x003F6FD7
		// (set) Token: 0x0601B502 RID: 111874 RVA: 0x003F8DDF File Offset: 0x003F6FDF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceActivityInfo ActivityInfo
		{
			get
			{
				return this.activityInfo_;
			}
			set
			{
				this.activityInfo_ = value;
			}
		}

		// Token: 0x0601B503 RID: 111875 RVA: 0x003F8DE8 File Offset: 0x003F6FE8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceInfoUpdateNotify);
		}

		// Token: 0x0601B504 RID: 111876 RVA: 0x003F8DF6 File Offset: 0x003F6FF6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityInfo, other.ActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B505 RID: 111877 RVA: 0x003F8E2C File Offset: 0x003F702C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.activityInfo_ != null)
			{
				num ^= this.ActivityInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B506 RID: 111878 RVA: 0x003F8E68 File Offset: 0x003F7068
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B507 RID: 111879 RVA: 0x003F8E75 File Offset: 0x003F7075
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B508 RID: 111880 RVA: 0x003F8E7E File Offset: 0x003F707E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityInfo_ != null)
			{
				output.WriteRawTag(114);
				output.WriteMessage(this.ActivityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B509 RID: 111881 RVA: 0x003F8EB0 File Offset: 0x003F70B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.activityInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.ActivityInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B50A RID: 111882 RVA: 0x003F8EF0 File Offset: 0x003F70F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.activityInfo_ != null)
			{
				if (this.activityInfo_ == null)
				{
					this.ActivityInfo = new TowerDefenceActivityInfo();
				}
				this.ActivityInfo.MergeFrom(other.ActivityInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B50B RID: 111883 RVA: 0x003F8F44 File Offset: 0x003F7144
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B50C RID: 111884 RVA: 0x003F8F50 File Offset: 0x003F7150
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
				if (num != 114U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.activityInfo_ == null)
					{
						this.ActivityInfo = new TowerDefenceActivityInfo();
					}
					input.ReadMessage(this.ActivityInfo);
				}
			}
		}

		// Token: 0x04009F1E RID: 40734
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009F1F RID: 40735
		public const int ActivityInfoFieldNumber = 14;

		// Token: 0x04009F20 RID: 40736
		private TowerDefenceActivityInfo activityInfo_;
	}
}
