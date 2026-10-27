using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200139F RID: 5023
	[NetMessage(EMessageId.TowerDefenceInfoUpdateNotify)]
	public sealed class TowerDefenceInfoUpdateNotify : IMessage<TowerDefenceInfoUpdateNotify>, IMessage, IEquatable<TowerDefenceInfoUpdateNotify>, IDeepCloneable<TowerDefenceInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601AA70 RID: 109168 RVA: 0x003DDAB9 File Offset: 0x003DBCB9
		[NullableContext(1)]
		public static TowerDefenceInfoUpdateNotify Create()
		{
			return new TowerDefenceInfoUpdateNotify();
		}

		// Token: 0x170059DE RID: 23006
		// (get) Token: 0x0601AA71 RID: 109169 RVA: 0x003DDAC0 File Offset: 0x003DBCC0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170059DF RID: 23007
		// (get) Token: 0x0601AA72 RID: 109170 RVA: 0x003DDAC3 File Offset: 0x003DBCC3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601AA73 RID: 109171 RVA: 0x003DDACA File Offset: 0x003DBCCA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInfoUpdateNotify()
		{
		}

		// Token: 0x0601AA74 RID: 109172 RVA: 0x003DDAD2 File Offset: 0x003DBCD2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInfoUpdateNotify(TowerDefenceInfoUpdateNotify other) : this()
		{
			this.activityInfo_ = ((other.activityInfo_ != null) ? other.activityInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AA75 RID: 109173 RVA: 0x003DDB07 File Offset: 0x003DBD07
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceInfoUpdateNotify Clone()
		{
			return new TowerDefenceInfoUpdateNotify(this);
		}

		// Token: 0x170059E0 RID: 23008
		// (get) Token: 0x0601AA76 RID: 109174 RVA: 0x003DDB0F File Offset: 0x003DBD0F
		// (set) Token: 0x0601AA77 RID: 109175 RVA: 0x003DDB17 File Offset: 0x003DBD17
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

		// Token: 0x0601AA78 RID: 109176 RVA: 0x003DDB20 File Offset: 0x003DBD20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceInfoUpdateNotify);
		}

		// Token: 0x0601AA79 RID: 109177 RVA: 0x003DDB2E File Offset: 0x003DBD2E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.ActivityInfo, other.ActivityInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AA7A RID: 109178 RVA: 0x003DDB64 File Offset: 0x003DBD64
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

		// Token: 0x0601AA7B RID: 109179 RVA: 0x003DDBA0 File Offset: 0x003DBDA0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AA7C RID: 109180 RVA: 0x003DDBAD File Offset: 0x003DBDAD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AA7D RID: 109181 RVA: 0x003DDBB6 File Offset: 0x003DBDB6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.activityInfo_ != null)
			{
				output.WriteRawTag(50);
				output.WriteMessage(this.ActivityInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AA7E RID: 109182 RVA: 0x003DDBE8 File Offset: 0x003DBDE8
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

		// Token: 0x0601AA7F RID: 109183 RVA: 0x003DDC28 File Offset: 0x003DBE28
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

		// Token: 0x0601AA80 RID: 109184 RVA: 0x003DDC7C File Offset: 0x003DBE7C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AA81 RID: 109185 RVA: 0x003DDC88 File Offset: 0x003DBE88
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
				if (num != 50U)
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

		// Token: 0x04009AD7 RID: 39639
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009AD8 RID: 39640
		public const int ActivityInfoFieldNumber = 6;

		// Token: 0x04009AD9 RID: 39641
		private TowerDefenceActivityInfo activityInfo_;
	}
}
