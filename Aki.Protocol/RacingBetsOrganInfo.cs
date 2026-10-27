using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000E6D RID: 3693
	public sealed class RacingBetsOrganInfo : IMessage<RacingBetsOrganInfo>, IMessage, IEquatable<RacingBetsOrganInfo>, IDeepCloneable<RacingBetsOrganInfo>, IBufferMessage
	{
		// Token: 0x06013D79 RID: 81273 RVA: 0x002E3E60 File Offset: 0x002E2060
		[NullableContext(1)]
		public static RacingBetsOrganInfo Create()
		{
			return new RacingBetsOrganInfo();
		}

		// Token: 0x170041FE RID: 16894
		// (get) Token: 0x06013D7A RID: 81274 RVA: 0x002E3E67 File Offset: 0x002E2067
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<RacingBetsOrganInfo> Parser
		{
			get
			{
				return RacingBetsOrganInfo._parser;
			}
		}

		// Token: 0x170041FF RID: 16895
		// (get) Token: 0x06013D7B RID: 81275 RVA: 0x002E3E6E File Offset: 0x002E206E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004200 RID: 16896
		// (get) Token: 0x06013D7C RID: 81276 RVA: 0x002E3E71 File Offset: 0x002E2071
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RacingBetsOrganInfo.Descriptor;
			}
		}

		// Token: 0x06013D7D RID: 81277 RVA: 0x002E3E78 File Offset: 0x002E2078
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganInfo()
		{
		}

		// Token: 0x06013D7E RID: 81278 RVA: 0x002E3E80 File Offset: 0x002E2080
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganInfo(RacingBetsOrganInfo other) : this()
		{
			this.id_ = other.id_;
			this.point_ = other.point_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06013D7F RID: 81279 RVA: 0x002E3EB1 File Offset: 0x002E20B1
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RacingBetsOrganInfo Clone()
		{
			return new RacingBetsOrganInfo(this);
		}

		// Token: 0x17004201 RID: 16897
		// (get) Token: 0x06013D80 RID: 81280 RVA: 0x002E3EB9 File Offset: 0x002E20B9
		// (set) Token: 0x06013D81 RID: 81281 RVA: 0x002E3EC1 File Offset: 0x002E20C1
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

		// Token: 0x17004202 RID: 16898
		// (get) Token: 0x06013D82 RID: 81282 RVA: 0x002E3ECA File Offset: 0x002E20CA
		// (set) Token: 0x06013D83 RID: 81283 RVA: 0x002E3ED2 File Offset: 0x002E20D2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Point
		{
			get
			{
				return this.point_;
			}
			set
			{
				this.point_ = value;
			}
		}

		// Token: 0x06013D84 RID: 81284 RVA: 0x002E3EDB File Offset: 0x002E20DB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RacingBetsOrganInfo);
		}

		// Token: 0x06013D85 RID: 81285 RVA: 0x002E3EE9 File Offset: 0x002E20E9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RacingBetsOrganInfo other)
		{
			return other != null && (other == this || (this.Id == other.Id && this.Point == other.Point && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06013D86 RID: 81286 RVA: 0x002E3F28 File Offset: 0x002E2128
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this.Point != 0)
			{
				num ^= this.Point.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06013D87 RID: 81287 RVA: 0x002E3F80 File Offset: 0x002E2180
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06013D88 RID: 81288 RVA: 0x002E3F8D File Offset: 0x002E218D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06013D89 RID: 81289 RVA: 0x002E3F98 File Offset: 0x002E2198
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Id);
			}
			if (this.Point != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Point);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06013D8A RID: 81290 RVA: 0x002E3FF0 File Offset: 0x002E21F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this.Point != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Point);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06013D8B RID: 81291 RVA: 0x002E4048 File Offset: 0x002E2248
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RacingBetsOrganInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			if (other.Point != 0)
			{
				this.Point = other.Point;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06013D8C RID: 81292 RVA: 0x002E4098 File Offset: 0x002E2298
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06013D8D RID: 81293 RVA: 0x002E40A4 File Offset: 0x002E22A4
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
				if (num != 8U)
				{
					if (num != 16U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.Point = input.ReadInt32();
					}
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007968 RID: 31080
		private static readonly MessageParser<RacingBetsOrganInfo> _parser = new MessageParser<RacingBetsOrganInfo>(() => new RacingBetsOrganInfo());

		// Token: 0x04007969 RID: 31081
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400796A RID: 31082
		public const int IdFieldNumber = 1;

		// Token: 0x0400796B RID: 31083
		private int id_;

		// Token: 0x0400796C RID: 31084
		public const int PointFieldNumber = 2;

		// Token: 0x0400796D RID: 31085
		private int point_;
	}
}
