using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001426 RID: 5158
	[NetMessage(EMessageId.TowerDefenceSelfPassRequest)]
	public sealed class TowerDefenceSelfPassRequest : IMessage<TowerDefenceSelfPassRequest>, IMessage, IEquatable<TowerDefenceSelfPassRequest>, IDeepCloneable<TowerDefenceSelfPassRequest>, IBufferMessage
	{
		// Token: 0x0601B6A3 RID: 112291 RVA: 0x003FC7E5 File Offset: 0x003FA9E5
		[NullableContext(1)]
		public static TowerDefenceSelfPassRequest Create()
		{
			return new TowerDefenceSelfPassRequest();
		}

		// Token: 0x17005CD1 RID: 23761
		// (get) Token: 0x0601B6A4 RID: 112292 RVA: 0x003FC7EC File Offset: 0x003FA9EC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005CD2 RID: 23762
		// (get) Token: 0x0601B6A5 RID: 112293 RVA: 0x003FC7EF File Offset: 0x003FA9EF
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return TowerDefenceSelfPassRequest.Descriptor;
			}
		}

		// Token: 0x0601B6A6 RID: 112294 RVA: 0x003FC7F6 File Offset: 0x003FA9F6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassRequest()
		{
		}

		// Token: 0x0601B6A7 RID: 112295 RVA: 0x003FC7FE File Offset: 0x003FA9FE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassRequest(TowerDefenceSelfPassRequest other) : this()
		{
			this.id_ = other.id_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601B6A8 RID: 112296 RVA: 0x003FC823 File Offset: 0x003FAA23
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public TowerDefenceSelfPassRequest Clone()
		{
			return new TowerDefenceSelfPassRequest(this);
		}

		// Token: 0x17005CD3 RID: 23763
		// (get) Token: 0x0601B6A9 RID: 112297 RVA: 0x003FC82B File Offset: 0x003FAA2B
		// (set) Token: 0x0601B6AA RID: 112298 RVA: 0x003FC833 File Offset: 0x003FAA33
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

		// Token: 0x0601B6AB RID: 112299 RVA: 0x003FC83C File Offset: 0x003FAA3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as TowerDefenceSelfPassRequest);
		}

		// Token: 0x0601B6AC RID: 112300 RVA: 0x003FC84A File Offset: 0x003FAA4A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(TowerDefenceSelfPassRequest other)
		{
			return other != null && (other == this || (this.Id == other.Id && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601B6AD RID: 112301 RVA: 0x003FC878 File Offset: 0x003FAA78
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Id != 0)
			{
				num ^= this.Id.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601B6AE RID: 112302 RVA: 0x003FC8B7 File Offset: 0x003FAAB7
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601B6AF RID: 112303 RVA: 0x003FC8C4 File Offset: 0x003FAAC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601B6B0 RID: 112304 RVA: 0x003FC8CD File Offset: 0x003FAACD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Id != 0)
			{
				output.WriteRawTag(88);
				output.WriteInt32(this.Id);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601B6B1 RID: 112305 RVA: 0x003FC900 File Offset: 0x003FAB00
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Id != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Id);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601B6B2 RID: 112306 RVA: 0x003FC93E File Offset: 0x003FAB3E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(TowerDefenceSelfPassRequest other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Id != 0)
			{
				this.Id = other.Id;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601B6B3 RID: 112307 RVA: 0x003FC96F File Offset: 0x003FAB6F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601B6B4 RID: 112308 RVA: 0x003FC978 File Offset: 0x003FAB78
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
				if (num != 88U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					this.Id = input.ReadInt32();
				}
			}
		}

		// Token: 0x04009FA2 RID: 40866
		private UnknownFieldSet _unknownFields;

		// Token: 0x04009FA3 RID: 40867
		public const int IdFieldNumber = 11;

		// Token: 0x04009FA4 RID: 40868
		private int id_;
	}
}
