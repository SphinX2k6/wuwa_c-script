using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020013D0 RID: 5072
	[NetMessage(EMessageId.TraceEntityPosRequest)]
	public sealed class TraceEntityPosRequest : IMessage<TraceEntityPosRequest>, IMessage, IEquatable<TraceEntityPosRequest>, IDeepCloneable<TraceEntityPosRequest>, IBufferMessage
	{
		// Token: 0x0601AE65 RID: 110181 RVA: 0x003E631C File Offset: 0x003E451C
		[NullableContext(1)]
		public static TraceEntityPosRequest Create()
		{
			return new TraceEntityPosRequest();
		}

		// Token: 0x17005AB7 RID: 23223
		// (get) Token: 0x0601AE66 RID: 110182 RVA: 0x003E6323 File Offset: 0x003E4523
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005AB8 RID: 23224
		// (get) Token: 0x0601AE67 RID: 110183 RVA: 0x003E6326 File Offset: 0x003E4526
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TraceEntityPosRequest.Descriptor;
			}
		}

		// Token: 0x0601AE68 RID: 110184 RVA: 0x003E632D File Offset: 0x003E452D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosRequest()
		{
		}

		// Token: 0x0601AE69 RID: 110185 RVA: 0x003E6335 File Offset: 0x003E4535
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosRequest(TraceEntityPosRequest other) : this()
		{
			this.configId_ = other.configId_;
			this.dungeonId_ = other.dungeonId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601AE6A RID: 110186 RVA: 0x003E6366 File Offset: 0x003E4566
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TraceEntityPosRequest Clone()
		{
			return new TraceEntityPosRequest(this);
		}

		// Token: 0x17005AB9 RID: 23225
		// (get) Token: 0x0601AE6B RID: 110187 RVA: 0x003E636E File Offset: 0x003E456E
		// (set) Token: 0x0601AE6C RID: 110188 RVA: 0x003E6376 File Offset: 0x003E4576
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int ConfigId
		{
			get
			{
				return this.configId_;
			}
			set
			{
				this.configId_ = value;
			}
		}

		// Token: 0x17005ABA RID: 23226
		// (get) Token: 0x0601AE6D RID: 110189 RVA: 0x003E637F File Offset: 0x003E457F
		// (set) Token: 0x0601AE6E RID: 110190 RVA: 0x003E6387 File Offset: 0x003E4587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int DungeonId
		{
			get
			{
				return this.dungeonId_;
			}
			set
			{
				this.dungeonId_ = value;
			}
		}

		// Token: 0x0601AE6F RID: 110191 RVA: 0x003E6390 File Offset: 0x003E4590
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TraceEntityPosRequest);
		}

		// Token: 0x0601AE70 RID: 110192 RVA: 0x003E639E File Offset: 0x003E459E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TraceEntityPosRequest other)
		{
			return other != null && (other == this || (this.ConfigId == other.ConfigId && this.DungeonId == other.DungeonId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601AE71 RID: 110193 RVA: 0x003E63DC File Offset: 0x003E45DC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.ConfigId != 0)
			{
				num ^= this.ConfigId.GetHashCode();
			}
			if (this.DungeonId != 0)
			{
				num ^= this.DungeonId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601AE72 RID: 110194 RVA: 0x003E6434 File Offset: 0x003E4634
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601AE73 RID: 110195 RVA: 0x003E6441 File Offset: 0x003E4641
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601AE74 RID: 110196 RVA: 0x003E644C File Offset: 0x003E464C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.ConfigId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.ConfigId);
			}
			if (this.DungeonId != 0)
			{
				output.WriteRawTag(72);
				output.WriteInt32(this.DungeonId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601AE75 RID: 110197 RVA: 0x003E64A8 File Offset: 0x003E46A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.ConfigId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.ConfigId);
			}
			if (this.DungeonId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.DungeonId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601AE76 RID: 110198 RVA: 0x003E6500 File Offset: 0x003E4700
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TraceEntityPosRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.ConfigId != 0)
			{
				this.ConfigId = other.ConfigId;
			}
			if (other.DungeonId != 0)
			{
				this.DungeonId = other.DungeonId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601AE77 RID: 110199 RVA: 0x003E6550 File Offset: 0x003E4750
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601AE78 RID: 110200 RVA: 0x003E655C File Offset: 0x003E475C
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
				if (num != 56U)
				{
					if (num != 72U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.DungeonId = input.ReadInt32();
					}
				}
				else
				{
					this.ConfigId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009C03 RID: 39939
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009C04 RID: 39940
		public const int ConfigIdFieldNumber = 7;

		// Token: 0x04009C05 RID: 39941
		private int configId_;

		// Token: 0x04009C06 RID: 39942
		public const int DungeonIdFieldNumber = 9;

		// Token: 0x04009C07 RID: 39943
		private int dungeonId_;
	}
}
