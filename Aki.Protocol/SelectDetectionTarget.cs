using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020011BE RID: 4542
	public sealed class SelectDetectionTarget : IMessage<SelectDetectionTarget>, IMessage, IEquatable<SelectDetectionTarget>, IDeepCloneable<SelectDetectionTarget>, IBufferMessage
	{
		// Token: 0x060183C6 RID: 99270 RVA: 0x003872F1 File Offset: 0x003854F1
		[NullableContext(1)]
		public static SelectDetectionTarget Create()
		{
			return new SelectDetectionTarget();
		}

		// Token: 0x170051A6 RID: 20902
		// (get) Token: 0x060183C7 RID: 99271 RVA: 0x003872F8 File Offset: 0x003854F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170051A7 RID: 20903
		// (get) Token: 0x060183C8 RID: 99272 RVA: 0x003872FB File Offset: 0x003854FB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SelectDetectionTarget.Descriptor;
			}
		}

		// Token: 0x060183C9 RID: 99273 RVA: 0x00387302 File Offset: 0x00385502
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTarget()
		{
		}

		// Token: 0x060183CA RID: 99274 RVA: 0x0038730C File Offset: 0x0038550C
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

		// Token: 0x060183CB RID: 99275 RVA: 0x00387360 File Offset: 0x00385560
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SelectDetectionTarget Clone()
		{
			return new SelectDetectionTarget(this);
		}

		// Token: 0x170051A8 RID: 20904
		// (get) Token: 0x060183CC RID: 99276 RVA: 0x00387368 File Offset: 0x00385568
		// (set) Token: 0x060183CD RID: 99277 RVA: 0x00387370 File Offset: 0x00385570
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

		// Token: 0x170051A9 RID: 20905
		// (get) Token: 0x060183CE RID: 99278 RVA: 0x00387379 File Offset: 0x00385579
		// (set) Token: 0x060183CF RID: 99279 RVA: 0x00387381 File Offset: 0x00385581
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

		// Token: 0x170051AA RID: 20906
		// (get) Token: 0x060183D0 RID: 99280 RVA: 0x0038738A File Offset: 0x0038558A
		// (set) Token: 0x060183D1 RID: 99281 RVA: 0x00387392 File Offset: 0x00385592
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

		// Token: 0x170051AB RID: 20907
		// (get) Token: 0x060183D2 RID: 99282 RVA: 0x0038739B File Offset: 0x0038559B
		// (set) Token: 0x060183D3 RID: 99283 RVA: 0x003873A3 File Offset: 0x003855A3
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

		// Token: 0x060183D4 RID: 99284 RVA: 0x003873AC File Offset: 0x003855AC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SelectDetectionTarget);
		}

		// Token: 0x060183D5 RID: 99285 RVA: 0x003873BC File Offset: 0x003855BC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SelectDetectionTarget other)
		{
			return other != null && (other == this || (this.DetectionId == other.DetectionId && this.Type == other.Type && this.Id == other.Id && this.MapId == other.MapId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x060183D6 RID: 99286 RVA: 0x00387428 File Offset: 0x00385628
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

		// Token: 0x060183D7 RID: 99287 RVA: 0x003874B8 File Offset: 0x003856B8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x060183D8 RID: 99288 RVA: 0x003874C5 File Offset: 0x003856C5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x060183D9 RID: 99289 RVA: 0x003874D0 File Offset: 0x003856D0
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

		// Token: 0x060183DA RID: 99290 RVA: 0x00387560 File Offset: 0x00385760
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

		// Token: 0x060183DB RID: 99291 RVA: 0x003875E8 File Offset: 0x003857E8
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

		// Token: 0x060183DC RID: 99292 RVA: 0x00387660 File Offset: 0x00385860
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x060183DD RID: 99293 RVA: 0x0038766C File Offset: 0x0038586C
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

		// Token: 0x04008FB4 RID: 36788
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008FB5 RID: 36789
		public const int DetectionIdFieldNumber = 1;

		// Token: 0x04008FB6 RID: 36790
		private int detectionId_;

		// Token: 0x04008FB7 RID: 36791
		public const int TypeFieldNumber = 2;

		// Token: 0x04008FB8 RID: 36792
		private DetectionType type_;

		// Token: 0x04008FB9 RID: 36793
		public const int IdFieldNumber = 3;

		// Token: 0x04008FBA RID: 36794
		private int id_;

		// Token: 0x04008FBB RID: 36795
		public const int MapIdFieldNumber = 4;

		// Token: 0x04008FBC RID: 36796
		private int mapId_;
	}
}
