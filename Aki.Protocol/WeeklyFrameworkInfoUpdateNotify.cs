using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001583 RID: 5507
	[NetMessage(EMessageId.WeeklyFrameworkInfoUpdateNotify)]
	public sealed class WeeklyFrameworkInfoUpdateNotify : IMessage<WeeklyFrameworkInfoUpdateNotify>, IMessage, IEquatable<WeeklyFrameworkInfoUpdateNotify>, IDeepCloneable<WeeklyFrameworkInfoUpdateNotify>, IBufferMessage
	{
		// Token: 0x0601D27E RID: 119422 RVA: 0x00438CAB File Offset: 0x00436EAB
		[NullableContext(1)]
		public static WeeklyFrameworkInfoUpdateNotify Create()
		{
			return new WeeklyFrameworkInfoUpdateNotify();
		}

		// Token: 0x170062A5 RID: 25253
		// (get) Token: 0x0601D27F RID: 119423 RVA: 0x00438CB2 File Offset: 0x00436EB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170062A6 RID: 25254
		// (get) Token: 0x0601D280 RID: 119424 RVA: 0x00438CB5 File Offset: 0x00436EB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return WeeklyFrameworkInfoUpdateNotify.Descriptor;
			}
		}

		// Token: 0x0601D281 RID: 119425 RVA: 0x00438CBC File Offset: 0x00436EBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoUpdateNotify()
		{
		}

		// Token: 0x0601D282 RID: 119426 RVA: 0x00438CC4 File Offset: 0x00436EC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoUpdateNotify(WeeklyFrameworkInfoUpdateNotify other) : this()
		{
			this.frameworkInfo_ = ((other.frameworkInfo_ != null) ? other.frameworkInfo_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601D283 RID: 119427 RVA: 0x00438CF9 File Offset: 0x00436EF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfoUpdateNotify Clone()
		{
			return new WeeklyFrameworkInfoUpdateNotify(this);
		}

		// Token: 0x170062A7 RID: 25255
		// (get) Token: 0x0601D284 RID: 119428 RVA: 0x00438D01 File Offset: 0x00436F01
		// (set) Token: 0x0601D285 RID: 119429 RVA: 0x00438D09 File Offset: 0x00436F09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public WeeklyFrameworkInfo FrameworkInfo
		{
			get
			{
				return this.frameworkInfo_;
			}
			set
			{
				this.frameworkInfo_ = value;
			}
		}

		// Token: 0x0601D286 RID: 119430 RVA: 0x00438D12 File Offset: 0x00436F12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as WeeklyFrameworkInfoUpdateNotify);
		}

		// Token: 0x0601D287 RID: 119431 RVA: 0x00438D20 File Offset: 0x00436F20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(WeeklyFrameworkInfoUpdateNotify other)
		{
			return other != null && (other == this || (object.Equals(this.FrameworkInfo, other.FrameworkInfo) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601D288 RID: 119432 RVA: 0x00438D54 File Offset: 0x00436F54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.frameworkInfo_ != null)
			{
				num ^= this.FrameworkInfo.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601D289 RID: 119433 RVA: 0x00438D90 File Offset: 0x00436F90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601D28A RID: 119434 RVA: 0x00438D9D File Offset: 0x00436F9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601D28B RID: 119435 RVA: 0x00438DA6 File Offset: 0x00436FA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.frameworkInfo_ != null)
			{
				output.WriteRawTag(18);
				output.WriteMessage(this.FrameworkInfo);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601D28C RID: 119436 RVA: 0x00438DD8 File Offset: 0x00436FD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.frameworkInfo_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.FrameworkInfo);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601D28D RID: 119437 RVA: 0x00438E18 File Offset: 0x00437018
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(WeeklyFrameworkInfoUpdateNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.frameworkInfo_ != null)
			{
				if (this.frameworkInfo_ == null)
				{
					this.FrameworkInfo = new WeeklyFrameworkInfo();
				}
				this.FrameworkInfo.MergeFrom(other.FrameworkInfo);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601D28E RID: 119438 RVA: 0x00438E6C File Offset: 0x0043706C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601D28F RID: 119439 RVA: 0x00438E78 File Offset: 0x00437078
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
				if (num != 18U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.frameworkInfo_ == null)
					{
						this.FrameworkInfo = new WeeklyFrameworkInfo();
					}
					input.ReadMessage(this.FrameworkInfo);
				}
			}
		}

		// Token: 0x0400A75E RID: 42846
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A75F RID: 42847
		public const int FrameworkInfoFieldNumber = 2;

		// Token: 0x0400A760 RID: 42848
		private WeeklyFrameworkInfo frameworkInfo_;
	}
}
