using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200107D RID: 4221
	[NetMessage(EMessageId.RoleMotionActiveNotify)]
	public sealed class RoleMotionActiveNotify : IMessage<RoleMotionActiveNotify>, IMessage, IEquatable<RoleMotionActiveNotify>, IDeepCloneable<RoleMotionActiveNotify>, IBufferMessage
	{
		// Token: 0x0601694E RID: 92494 RVA: 0x00349235 File Offset: 0x00347435
		[NullableContext(1)]
		public static RoleMotionActiveNotify Create()
		{
			return new RoleMotionActiveNotify();
		}

		// Token: 0x17004BAE RID: 19374
		// (get) Token: 0x0601694F RID: 92495 RVA: 0x0034923C File Offset: 0x0034743C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004BAF RID: 19375
		// (get) Token: 0x06016950 RID: 92496 RVA: 0x0034923F File Offset: 0x0034743F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleMotionActiveNotify.Descriptor;
			}
		}

		// Token: 0x06016951 RID: 92497 RVA: 0x00349246 File Offset: 0x00347446
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionActiveNotify()
		{
		}

		// Token: 0x06016952 RID: 92498 RVA: 0x0034924E File Offset: 0x0034744E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionActiveNotify(RoleMotionActiveNotify other) : this()
		{
			this.roleMotionInfo_ = ((other.roleMotionInfo_ != null) ? other.roleMotionInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06016953 RID: 92499 RVA: 0x00349283 File Offset: 0x00347483
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotionActiveNotify Clone()
		{
			return new RoleMotionActiveNotify(this);
		}

		// Token: 0x17004BB0 RID: 19376
		// (get) Token: 0x06016954 RID: 92500 RVA: 0x0034928B File Offset: 0x0034748B
		// (set) Token: 0x06016955 RID: 92501 RVA: 0x00349293 File Offset: 0x00347493
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleMotion RoleMotionInfo
		{
			get
			{
				return this.roleMotionInfo_;
			}
			set
			{
				this.roleMotionInfo_ = value;
			}
		}

		// Token: 0x06016956 RID: 92502 RVA: 0x0034929C File Offset: 0x0034749C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleMotionActiveNotify);
		}

		// Token: 0x06016957 RID: 92503 RVA: 0x003492AA File Offset: 0x003474AA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleMotionActiveNotify other)
		{
			return other != null && (other == this || (object.Equals(this.RoleMotionInfo, other.RoleMotionInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06016958 RID: 92504 RVA: 0x003492E0 File Offset: 0x003474E0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.roleMotionInfo_ != null)
			{
				num ^= this.RoleMotionInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06016959 RID: 92505 RVA: 0x0034931C File Offset: 0x0034751C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601695A RID: 92506 RVA: 0x00349329 File Offset: 0x00347529
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601695B RID: 92507 RVA: 0x00349332 File Offset: 0x00347532
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.roleMotionInfo_ != null)
			{
				output.WriteRawTag(42);
				output.WriteMessage(this.RoleMotionInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601695C RID: 92508 RVA: 0x00349364 File Offset: 0x00347564
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.roleMotionInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.RoleMotionInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601695D RID: 92509 RVA: 0x003493A4 File Offset: 0x003475A4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleMotionActiveNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.roleMotionInfo_ != null)
			{
				if (this.roleMotionInfo_ == null)
				{
					this.RoleMotionInfo = new RoleMotion();
				}
				this.RoleMotionInfo.MergeFrom(other.RoleMotionInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601695E RID: 92510 RVA: 0x003493F8 File Offset: 0x003475F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601695F RID: 92511 RVA: 0x00349404 File Offset: 0x00347604
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
				if (num != 42U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.roleMotionInfo_ == null)
					{
						this.RoleMotionInfo = new RoleMotion();
					}
					input.ReadMessage(this.RoleMotionInfo);
				}
			}
		}

		// Token: 0x0400877F RID: 34687
		private UnknownFieldSet _unknownFields;

		// Token: 0x04008780 RID: 34688
		public const int RoleMotionInfoFieldNumber = 5;

		// Token: 0x04008781 RID: 34689
		private RoleMotion roleMotionInfo_;
	}
}
