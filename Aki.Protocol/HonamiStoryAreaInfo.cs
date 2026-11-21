using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200074E RID: 1870
	public sealed class HonamiStoryAreaInfo : IMessage<HonamiStoryAreaInfo>, IMessage, IEquatable<HonamiStoryAreaInfo>, IDeepCloneable<HonamiStoryAreaInfo>, IBufferMessage
	{
		// Token: 0x0600A9B9 RID: 43449 RVA: 0x0019920C File Offset: 0x0019740C
		[NullableContext(1)]
		public static HonamiStoryAreaInfo Create()
		{
			return new HonamiStoryAreaInfo();
		}

		// Token: 0x17002230 RID: 8752
		// (get) Token: 0x0600A9BA RID: 43450 RVA: 0x00199213 File Offset: 0x00197413
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageParser<HonamiStoryAreaInfo> Parser
		{
			get
			{
				return HonamiStoryAreaInfo._parser;
			}
		}

		// Token: 0x17002231 RID: 8753
		// (get) Token: 0x0600A9BB RID: 43451 RVA: 0x0019921A File Offset: 0x0019741A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17002232 RID: 8754
		// (get) Token: 0x0600A9BC RID: 43452 RVA: 0x0019921D File Offset: 0x0019741D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return HonamiStoryAreaInfo.Descriptor;
			}
		}

		// Token: 0x0600A9BD RID: 43453 RVA: 0x00199224 File Offset: 0x00197424
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfo()
		{
		}

		// Token: 0x0600A9BE RID: 43454 RVA: 0x0019922C File Offset: 0x0019742C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfo(HonamiStoryAreaInfo other) : this()
		{
			this.honamiStoryAreaId_ = other.honamiStoryAreaId_;
			this.status_ = other.status_;
			this.secreteStatus_ = other.secreteStatus_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0600A9BF RID: 43455 RVA: 0x00199269 File Offset: 0x00197469
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public HonamiStoryAreaInfo Clone()
		{
			return new HonamiStoryAreaInfo(this);
		}

		// Token: 0x17002233 RID: 8755
		// (get) Token: 0x0600A9C0 RID: 43456 RVA: 0x00199271 File Offset: 0x00197471
		// (set) Token: 0x0600A9C1 RID: 43457 RVA: 0x00199279 File Offset: 0x00197479
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int HonamiStoryAreaId
		{
			get
			{
				return this.honamiStoryAreaId_;
			}
			set
			{
				this.honamiStoryAreaId_ = value;
			}
		}

		// Token: 0x17002234 RID: 8756
		// (get) Token: 0x0600A9C2 RID: 43458 RVA: 0x00199282 File Offset: 0x00197482
		// (set) Token: 0x0600A9C3 RID: 43459 RVA: 0x0019928A File Offset: 0x0019748A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Status
		{
			get
			{
				return this.status_;
			}
			set
			{
				this.status_ = value;
			}
		}

		// Token: 0x17002235 RID: 8757
		// (get) Token: 0x0600A9C4 RID: 43460 RVA: 0x00199293 File Offset: 0x00197493
		// (set) Token: 0x0600A9C5 RID: 43461 RVA: 0x0019929B File Offset: 0x0019749B
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SecreteStatus
		{
			get
			{
				return this.secreteStatus_;
			}
			set
			{
				this.secreteStatus_ = value;
			}
		}

		// Token: 0x0600A9C6 RID: 43462 RVA: 0x001992A4 File Offset: 0x001974A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as HonamiStoryAreaInfo);
		}

		// Token: 0x0600A9C7 RID: 43463 RVA: 0x001992B4 File Offset: 0x001974B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(HonamiStoryAreaInfo other)
		{
			return other != null && (other == this || (this.HonamiStoryAreaId == other.HonamiStoryAreaId && this.Status == other.Status && this.SecreteStatus == other.SecreteStatus && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0600A9C8 RID: 43464 RVA: 0x00199310 File Offset: 0x00197510
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.HonamiStoryAreaId != 0)
			{
				num ^= this.HonamiStoryAreaId.GetHashCode();
			}
			if (this.Status != 0)
			{
				num ^= this.Status.GetHashCode();
			}
			if (this.SecreteStatus != 0)
			{
				num ^= this.SecreteStatus.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0600A9C9 RID: 43465 RVA: 0x00199381 File Offset: 0x00197581
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0600A9CA RID: 43466 RVA: 0x0019938E File Offset: 0x0019758E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0600A9CB RID: 43467 RVA: 0x00199398 File Offset: 0x00197598
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.HonamiStoryAreaId != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.HonamiStoryAreaId);
			}
			if (this.Status != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.Status);
			}
			if (this.SecreteStatus != 0)
			{
				output.WriteRawTag(24);
				output.WriteInt32(this.SecreteStatus);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0600A9CC RID: 43468 RVA: 0x0019940C File Offset: 0x0019760C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.HonamiStoryAreaId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.HonamiStoryAreaId);
			}
			if (this.Status != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Status);
			}
			if (this.SecreteStatus != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SecreteStatus);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0600A9CD RID: 43469 RVA: 0x0019947C File Offset: 0x0019767C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(HonamiStoryAreaInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.HonamiStoryAreaId != 0)
			{
				this.HonamiStoryAreaId = other.HonamiStoryAreaId;
			}
			if (other.Status != 0)
			{
				this.Status = other.Status;
			}
			if (other.SecreteStatus != 0)
			{
				this.SecreteStatus = other.SecreteStatus;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0600A9CE RID: 43470 RVA: 0x001994E0 File Offset: 0x001976E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0600A9CF RID: 43471 RVA: 0x001994EC File Offset: 0x001976EC
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
						if (num != 24U)
						{
							this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
						}
						else
						{
							this.SecreteStatus = input.ReadInt32();
						}
					}
					else
					{
						this.Status = input.ReadInt32();
					}
				}
				else
				{
					this.HonamiStoryAreaId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04004DB6 RID: 19894
		private static readonly MessageParser<HonamiStoryAreaInfo> _parser = new MessageParser<HonamiStoryAreaInfo>(() => new HonamiStoryAreaInfo());

		// Token: 0x04004DB7 RID: 19895
		private UnknownFieldSet _unknownFields;

		// Token: 0x04004DB8 RID: 19896
		public const int HonamiStoryAreaIdFieldNumber = 1;

		// Token: 0x04004DB9 RID: 19897
		private int honamiStoryAreaId_;

		// Token: 0x04004DBA RID: 19898
		public const int StatusFieldNumber = 2;

		// Token: 0x04004DBB RID: 19899
		private int status_;

		// Token: 0x04004DBC RID: 19900
		public const int SecreteStatusFieldNumber = 3;

		// Token: 0x04004DBD RID: 19901
		private int secreteStatus_;
	}
}
