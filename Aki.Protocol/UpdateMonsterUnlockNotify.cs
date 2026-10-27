using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x0200149C RID: 5276
	[NetMessage(EMessageId.UpdateMonsterUnlockNotify)]
	public sealed class UpdateMonsterUnlockNotify : IMessage<UpdateMonsterUnlockNotify>, IMessage, IEquatable<UpdateMonsterUnlockNotify>, IDeepCloneable<UpdateMonsterUnlockNotify>, IBufferMessage
	{
		// Token: 0x0601BE81 RID: 114305 RVA: 0x00408AAB File Offset: 0x00406CAB
		[NullableContext(1)]
		public static UpdateMonsterUnlockNotify Create()
		{
			return new UpdateMonsterUnlockNotify();
		}

		// Token: 0x17005E0C RID: 24076
		// (get) Token: 0x0601BE82 RID: 114306 RVA: 0x00408AB2 File Offset: 0x00406CB2
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17005E0D RID: 24077
		// (get) Token: 0x0601BE83 RID: 114307 RVA: 0x00408AB5 File Offset: 0x00406CB5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return UpdateMonsterUnlockNotify.Descriptor;
			}
		}

		// Token: 0x0601BE84 RID: 114308 RVA: 0x00408ABC File Offset: 0x00406CBC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMonsterUnlockNotify()
		{
		}

		// Token: 0x0601BE85 RID: 114309 RVA: 0x00408AC4 File Offset: 0x00406CC4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMonsterUnlockNotify(UpdateMonsterUnlockNotify other) : this()
		{
			this.detectionUnlocks_ = ((other.detectionUnlocks_ != null) ? other.detectionUnlocks_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601BE86 RID: 114310 RVA: 0x00408AF9 File Offset: 0x00406CF9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public UpdateMonsterUnlockNotify Clone()
		{
			return new UpdateMonsterUnlockNotify(this);
		}

		// Token: 0x17005E0E RID: 24078
		// (get) Token: 0x0601BE87 RID: 114311 RVA: 0x00408B01 File Offset: 0x00406D01
		// (set) Token: 0x0601BE88 RID: 114312 RVA: 0x00408B09 File Offset: 0x00406D09
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public DetectionUnlock DetectionUnlocks
		{
			get
			{
				return this.detectionUnlocks_;
			}
			set
			{
				this.detectionUnlocks_ = value;
			}
		}

		// Token: 0x0601BE89 RID: 114313 RVA: 0x00408B12 File Offset: 0x00406D12
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as UpdateMonsterUnlockNotify);
		}

		// Token: 0x0601BE8A RID: 114314 RVA: 0x00408B20 File Offset: 0x00406D20
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(UpdateMonsterUnlockNotify other)
		{
			return other != null && (other == this || (object.Equals(this.DetectionUnlocks, other.DetectionUnlocks) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x0601BE8B RID: 114315 RVA: 0x00408B54 File Offset: 0x00406D54
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.detectionUnlocks_ != null)
			{
				num ^= this.DetectionUnlocks.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601BE8C RID: 114316 RVA: 0x00408B90 File Offset: 0x00406D90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601BE8D RID: 114317 RVA: 0x00408B9D File Offset: 0x00406D9D
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601BE8E RID: 114318 RVA: 0x00408BA6 File Offset: 0x00406DA6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.detectionUnlocks_ != null)
			{
				output.WriteRawTag(10);
				output.WriteMessage(this.DetectionUnlocks);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601BE8F RID: 114319 RVA: 0x00408BD8 File Offset: 0x00406DD8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.detectionUnlocks_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.DetectionUnlocks);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601BE90 RID: 114320 RVA: 0x00408C18 File Offset: 0x00406E18
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(UpdateMonsterUnlockNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.detectionUnlocks_ != null)
			{
				if (this.detectionUnlocks_ == null)
				{
					this.DetectionUnlocks = new DetectionUnlock();
				}
				this.DetectionUnlocks.MergeFrom(other.DetectionUnlocks);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601BE91 RID: 114321 RVA: 0x00408C6C File Offset: 0x00406E6C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x0601BE92 RID: 114322 RVA: 0x00408C78 File Offset: 0x00406E78
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
				if (num != 10U)
				{
					this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
				}
				else
				{
					if (this.detectionUnlocks_ == null)
					{
						this.DetectionUnlocks = new DetectionUnlock();
					}
					input.ReadMessage(this.DetectionUnlocks);
				}
			}
		}

		// Token: 0x0400A063 RID: 41059
		private UnknownFieldSet _unknownFields;

		// Token: 0x0400A064 RID: 41060
		public const int DetectionUnlocksFieldNumber = 1;

		// Token: 0x0400A065 RID: 41061
		private DetectionUnlock detectionUnlocks_;
	}
}
