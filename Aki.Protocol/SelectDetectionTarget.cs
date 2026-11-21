using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011F8 RID: 4600
	public sealed class SelectDetectionTarget : IMessage<SelectDetectionTarget>, IMessage, IEquatable<SelectDetectionTarget>, IDeepCloneable<SelectDetectionTarget>, IBufferMessage
	{
		// Token: 0x06018967 RID: 100711 RVA: 0x00396621 File Offset: 0x00394821
		[NullableContext(1)]
		public static SelectDetectionTarget Create()
		{
			return new SelectDetectionTarget();
		}

		// Token: 0x17005312 RID: 21266
		// (get) Token: 0x06018968 RID: 100712 RVA: 0x00396628 File Offset: 0x00394828
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005313 RID: 21267
		// (get) Token: 0x06018969 RID: 100713 RVA: 0x0039662B File Offset: 0x0039482B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectDetectionTarget.Descriptor;
			}
		}

		// Token: 0x0601896A RID: 100714 RVA: 0x00396632 File Offset: 0x00394832
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTarget()
		{
		}

		// Token: 0x0601896B RID: 100715 RVA: 0x0039663C File Offset: 0x0039483C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTarget(SelectDetectionTarget other) : this()
		{
			this.detectionId_ = other.detectionId_;
			this.type_ = other.type_;
			this.id_ = other.id_;
			this.mapId_ = other.mapId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601896C RID: 100716 RVA: 0x00396690 File Offset: 0x00394890
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTarget Clone()
		{
			return new SelectDetectionTarget(this);
		}

		// Token: 0x17005314 RID: 21268
		// (get) Token: 0x0601896D RID: 100717 RVA: 0x00396698 File Offset: 0x00394898
		// (set) Token: 0x0601896E RID: 100718 RVA: 0x003966A0 File Offset: 0x003948A0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DetectionId
		{
			get
			{
				return this.detectionId_;
			}
			set
			{
				this.detectionId_ = value;
			}
		}

		// Token: 0x17005315 RID: 21269
		// (get) Token: 0x0601896F RID: 100719 RVA: 0x003966A9 File Offset: 0x003948A9
		// (set) Token: 0x06018970 RID: 100720 RVA: 0x003966B1 File Offset: 0x003948B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionType Type
		{
			get
			{
				return this.type_;
			}
			set
			{
				this.type_ = value;
			}
		}

		// Token: 0x17005316 RID: 21270
		// (get) Token: 0x06018971 RID: 100721 RVA: 0x003966BA File Offset: 0x003948BA
		// (set) Token: 0x06018972 RID: 100722 RVA: 0x003966C2 File Offset: 0x003948C2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Id
		{
			get
			{
				return this.id_;
			}
			set
			{
				this.id_ = value;
			}
		}

		// Token: 0x17005317 RID: 21271
		// (get) Token: 0x06018973 RID: 100723 RVA: 0x003966CB File Offset: 0x003948CB
		// (set) Token: 0x06018974 RID: 100724 RVA: 0x003966D3 File Offset: 0x003948D3
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int MapId
		{
			get
			{
				return this.mapId_;
			}
			set
			{
				this.mapId_ = value;
			}
		}

		// Token: 0x06018975 RID: 100725 RVA: 0x003966DC File Offset: 0x003948DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectDetectionTarget);
		}

		// Token: 0x06018976 RID: 100726 RVA: 0x003966EC File Offset: 0x003948EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectDetectionTarget other)
		{
			return other != null && (other == this || (this.DetectionId == other.DetectionId && this.Type == other.Type && this.Id == other.Id && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06018977 RID: 100727 RVA: 0x00396758 File Offset: 0x00394958
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.DetectionId != 0)
			{
				num ^= this.DetectionId.GetHashCode();
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				num ^= this.Type.GetHashCode();
			}
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.MapId != 0)
			{
				num ^= this.MapId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06018978 RID: 100728 RVA: 0x003967E8 File Offset: 0x003949E8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06018979 RID: 100729 RVA: 0x003967F5 File Offset: 0x003949F5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601897A RID: 100730 RVA: 0x00396800 File Offset: 0x00394A00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.DetectionId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.DetectionId);
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				output.WriteRawTag(16);
				output.WriteEnum((int)this.Type);
			}
			if (this.Id != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.Id);
			}
			if (this.MapId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.MapId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601897B RID: 100731 RVA: 0x00396890 File Offset: 0x00394A90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.DetectionId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DetectionId);
			}
			if (this.Type != DetectionType.NormalMonster)
			{
				num += 1 + CodedOutputStream.ComputeEnumSize((int)this.Type);
			}
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.MapId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.MapId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601897C RID: 100732 RVA: 0x00396918 File Offset: 0x00394B18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SelectDetectionTarget other)
		{
			if (other == null)
			{
				return;
			}
			if (other.DetectionId != 0)
			{
				this.DetectionId = other.DetectionId;
			}
			if (other.Type != DetectionType.NormalMonster)
			{
				this.Type = other.Type;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.MapId != 0)
			{
				this.MapId = other.MapId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601897D RID: 100733 RVA: 0x00396990 File Offset: 0x00394B90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601897E RID: 100734 RVA: 0x0039699C File Offset: 0x00394B9C
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
				if (num <= 16U)
				{
					if (num == 8U)
					{
						this.DetectionId = input.ReadInt32();
						continue;
					}
					if (num == 16U)
					{
						this.Type = (DetectionType)input.ReadEnum();
						continue;
					}
				}
				else
				{
					if (num == 24U)
					{
						this.Id = input.ReadInt32();
						continue;
					}
					if (num == 32U)
					{
						this.MapId = input.ReadInt32();
						continue;
					}
				}
				this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
			}
		}

		// Token: 0x04009247 RID: 37447
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009248 RID: 37448
		public const int DetectionIdFieldNumber = 1;

		// Token: 0x04009249 RID: 37449
		private int detectionId_;

		// Token: 0x0400924A RID: 37450
		public const int TypeFieldNumber = 2;

		// Token: 0x0400924B RID: 37451
		private DetectionType type_;

		// Token: 0x0400924C RID: 37452
		public const int IdFieldNumber = 3;

		// Token: 0x0400924D RID: 37453
		private int id_;

		// Token: 0x0400924E RID: 37454
		public const int MapIdFieldNumber = 4;

		// Token: 0x0400924F RID: 37455
		private int mapId_;
	}
}
