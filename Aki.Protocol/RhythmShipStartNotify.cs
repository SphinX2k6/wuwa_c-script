using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F3C RID: 3900
	[NetMessage(EMessageId.RhythmShipStartNotify)]
	public sealed class RhythmShipStartNotify : IMessage<RhythmShipStartNotify>, IMessage, IEquatable<RhythmShipStartNotify>, IDeepCloneable<RhythmShipStartNotify>, IBufferMessage
	{
		// Token: 0x06014E54 RID: 85588 RVA: 0x00308CC4 File Offset: 0x00306EC4
		[NullableContext(1)]
		public static RhythmShipStartNotify Create()
		{
			return new RhythmShipStartNotify();
		}

		// Token: 0x17004586 RID: 17798
		// (get) Token: 0x06014E55 RID: 85589 RVA: 0x00308CCB File Offset: 0x00306ECB
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004587 RID: 17799
		// (get) Token: 0x06014E56 RID: 85590 RVA: 0x00308CCE File Offset: 0x00306ECE
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmShipStartNotify.Descriptor;
			}
		}

		// Token: 0x06014E57 RID: 85591 RVA: 0x00308CD5 File Offset: 0x00306ED5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipStartNotify()
		{
		}

		// Token: 0x06014E58 RID: 85592 RVA: 0x00308CDD File Offset: 0x00306EDD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipStartNotify(RhythmShipStartNotify other) : this()
		{
			this.subLevelId_ = other.subLevelId_;
			this.rhythmRoleId_ = other.rhythmRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014E59 RID: 85593 RVA: 0x00308D0E File Offset: 0x00306F0E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipStartNotify Clone()
		{
			return new RhythmShipStartNotify(this);
		}

		// Token: 0x17004588 RID: 17800
		// (get) Token: 0x06014E5A RID: 85594 RVA: 0x00308D16 File Offset: 0x00306F16
		// (set) Token: 0x06014E5B RID: 85595 RVA: 0x00308D1E File Offset: 0x00306F1E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int SubLevelId
		{
			get
			{
				return this.subLevelId_;
			}
			set
			{
				this.subLevelId_ = value;
			}
		}

		// Token: 0x17004589 RID: 17801
		// (get) Token: 0x06014E5C RID: 85596 RVA: 0x00308D27 File Offset: 0x00306F27
		// (set) Token: 0x06014E5D RID: 85597 RVA: 0x00308D2F File Offset: 0x00306F2F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int RhythmRoleId
		{
			get
			{
				return this.rhythmRoleId_;
			}
			set
			{
				this.rhythmRoleId_ = value;
			}
		}

		// Token: 0x06014E5E RID: 85598 RVA: 0x00308D38 File Offset: 0x00306F38
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmShipStartNotify);
		}

		// Token: 0x06014E5F RID: 85599 RVA: 0x00308D46 File Offset: 0x00306F46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmShipStartNotify other)
		{
			return other != null && (other == this || (this.SubLevelId == other.SubLevelId && this.RhythmRoleId == other.RhythmRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014E60 RID: 85600 RVA: 0x00308D84 File Offset: 0x00306F84
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.SubLevelId != 0)
			{
				num ^= this.SubLevelId.GetHashCode();
			}
			if (this.RhythmRoleId != 0)
			{
				num ^= this.RhythmRoleId.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06014E61 RID: 85601 RVA: 0x00308DDC File Offset: 0x00306FDC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014E62 RID: 85602 RVA: 0x00308DE9 File Offset: 0x00306FE9
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014E63 RID: 85603 RVA: 0x00308DF4 File Offset: 0x00306FF4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.RhythmRoleId != 0)
			{
				output.WriteRawTag(40);
				output.WriteInt32(this.RhythmRoleId);
			}
			if (this.SubLevelId != 0)
			{
				output.WriteRawTag(48);
				output.WriteInt32(this.SubLevelId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014E64 RID: 85604 RVA: 0x00308E50 File Offset: 0x00307050
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.SubLevelId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.SubLevelId);
			}
			if (this.RhythmRoleId != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.RhythmRoleId);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06014E65 RID: 85605 RVA: 0x00308EA8 File Offset: 0x003070A8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RhythmShipStartNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.SubLevelId != 0)
			{
				this.SubLevelId = other.SubLevelId;
			}
			if (other.RhythmRoleId != 0)
			{
				this.RhythmRoleId = other.RhythmRoleId;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06014E66 RID: 85606 RVA: 0x00308EF8 File Offset: 0x003070F8
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014E67 RID: 85607 RVA: 0x00308F04 File Offset: 0x00307104
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
				if (num != 40U)
				{
					if (num != 48U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.SubLevelId = input.ReadInt32();
					}
				}
				else
				{
					this.RhythmRoleId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E7E RID: 32382
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E7F RID: 32383
		public const int SubLevelIdFieldNumber = 6;

		// Token: 0x04007E80 RID: 32384
		private int subLevelId_;

		// Token: 0x04007E81 RID: 32385
		public const int RhythmRoleIdFieldNumber = 5;

		// Token: 0x04007E82 RID: 32386
		private int rhythmRoleId_;
	}
}
