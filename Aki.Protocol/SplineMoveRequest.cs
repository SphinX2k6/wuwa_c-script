using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200126D RID: 4717
	[NetMessage(EMessageId.SplineMoveRequest)]
	public sealed class SplineMoveRequest : IMessage<SplineMoveRequest>, IMessage, IEquatable<SplineMoveRequest>, IDeepCloneable<SplineMoveRequest>, IBufferMessage
	{
		// Token: 0x06019204 RID: 102916 RVA: 0x003A798E File Offset: 0x003A5B8E
		[NullableContext(1)]
		public static SplineMoveRequest Create()
		{
			return new SplineMoveRequest();
		}

		// Token: 0x170054BD RID: 21693
		// (get) Token: 0x06019205 RID: 102917 RVA: 0x003A7995 File Offset: 0x003A5B95
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054BE RID: 21694
		// (get) Token: 0x06019206 RID: 102918 RVA: 0x003A7998 File Offset: 0x003A5B98
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SplineMoveRequest.Descriptor;
			}
		}

		// Token: 0x06019207 RID: 102919 RVA: 0x003A799F File Offset: 0x003A5B9F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveRequest()
		{
		}

		// Token: 0x06019208 RID: 102920 RVA: 0x003A79A8 File Offset: 0x003A5BA8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveRequest(SplineMoveRequest other) : this()
		{
			this.entityId_ = other.entityId_;
			this.pathId_ = other.pathId_;
			this.pathRatio_ = other.pathRatio_;
			this.pos_ = ((other.pos_ != null) ? other.pos_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019209 RID: 102921 RVA: 0x003A7A0C File Offset: 0x003A5C0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SplineMoveRequest Clone()
		{
			return new SplineMoveRequest(this);
		}

		// Token: 0x170054BF RID: 21695
		// (get) Token: 0x0601920A RID: 102922 RVA: 0x003A7A14 File Offset: 0x003A5C14
		// (set) Token: 0x0601920B RID: 102923 RVA: 0x003A7A1C File Offset: 0x003A5C1C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170054C0 RID: 21696
		// (get) Token: 0x0601920C RID: 102924 RVA: 0x003A7A25 File Offset: 0x003A5C25
		// (set) Token: 0x0601920D RID: 102925 RVA: 0x003A7A2D File Offset: 0x003A5C2D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PathId
		{
			get
			{
				return this.pathId_;
			}
			set
			{
				this.pathId_ = value;
			}
		}

		// Token: 0x170054C1 RID: 21697
		// (get) Token: 0x0601920E RID: 102926 RVA: 0x003A7A36 File Offset: 0x003A5C36
		// (set) Token: 0x0601920F RID: 102927 RVA: 0x003A7A3E File Offset: 0x003A5C3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int PathRatio
		{
			get
			{
				return this.pathRatio_;
			}
			set
			{
				this.pathRatio_ = value;
			}
		}

		// Token: 0x170054C2 RID: 21698
		// (get) Token: 0x06019210 RID: 102928 RVA: 0x003A7A47 File Offset: 0x003A5C47
		// (set) Token: 0x06019211 RID: 102929 RVA: 0x003A7A4F File Offset: 0x003A5C4F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public Vector Pos
		{
			get
			{
				return this.pos_;
			}
			set
			{
				this.pos_ = value;
			}
		}

		// Token: 0x06019212 RID: 102930 RVA: 0x003A7A58 File Offset: 0x003A5C58
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SplineMoveRequest);
		}

		// Token: 0x06019213 RID: 102931 RVA: 0x003A7A68 File Offset: 0x003A5C68
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SplineMoveRequest other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && this.PathId == other.PathId && this.PathRatio == other.PathRatio && object.Equals(this.Pos, other.Pos) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019214 RID: 102932 RVA: 0x003A7AD8 File Offset: 0x003A5CD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.PathId != 0)
			{
				num ^= this.PathId.GetHashCode();
			}
			if (this.PathRatio != 0)
			{
				num ^= this.PathRatio.GetHashCode();
			}
			if (this.pos_ != null)
			{
				num ^= this.Pos.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06019215 RID: 102933 RVA: 0x003A7B5F File Offset: 0x003A5D5F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06019216 RID: 102934 RVA: 0x003A7B6C File Offset: 0x003A5D6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06019217 RID: 102935 RVA: 0x003A7B78 File Offset: 0x003A5D78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.pos_ != null)
			{
				output.WriteRawTag(90);
				output.WriteMessage(this.Pos);
			}
			if (this.PathId != 0)
			{
				output.WriteRawTag(96);
				output.WriteInt32(this.PathId);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(104);
				output.WriteInt64(this.EntityId);
			}
			if (this.PathRatio != 0)
			{
				output.WriteRawTag(112);
				output.WriteInt32(this.PathRatio);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06019218 RID: 102936 RVA: 0x003A7C0C File Offset: 0x003A5E0C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.PathId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PathId);
			}
			if (this.PathRatio != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.PathRatio);
			}
			if (this.pos_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.Pos);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06019219 RID: 102937 RVA: 0x003A7C94 File Offset: 0x003A5E94
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SplineMoveRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.PathId != 0)
			{
				this.PathId = other.PathId;
			}
			if (other.PathRatio != 0)
			{
				this.PathRatio = other.PathRatio;
			}
			if (other.pos_ != null)
			{
				if (this.pos_ == null)
				{
					this.Pos = new Vector();
				}
				this.Pos.MergeFrom(other.Pos);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601921A RID: 102938 RVA: 0x003A7D24 File Offset: 0x003A5F24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601921B RID: 102939 RVA: 0x003A7D30 File Offset: 0x003A5F30
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
				if (num <= 96U)
				{
					if (num == 90U)
					{
						if (this.pos_ == null)
						{
							this.Pos = new Vector();
						}
						input.ReadMessage(this.Pos);
						continue;
					}
					if (num == 96U)
					{
						this.PathId = input.ReadInt32();
						continue;
					}
				}
				else
				{
					if (num == 104U)
					{
						this.EntityId = input.ReadInt64();
						continue;
					}
					if (num == 112U)
					{
						this.PathRatio = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x040093E5 RID: 37861
		private UnknownFieldSet _unknownFields;

		// Token: 0x040093E6 RID: 37862
		public const int EntityIdFieldNumber = 13;

		// Token: 0x040093E7 RID: 37863
		private long entityId_;

		// Token: 0x040093E8 RID: 37864
		public const int PathIdFieldNumber = 12;

		// Token: 0x040093E9 RID: 37865
		private int pathId_;

		// Token: 0x040093EA RID: 37866
		public const int PathRatioFieldNumber = 14;

		// Token: 0x040093EB RID: 37867
		private int pathRatio_;

		// Token: 0x040093EC RID: 37868
		public const int PosFieldNumber = 11;

		// Token: 0x040093ED RID: 37869
		private Vector pos_;
	}
}
