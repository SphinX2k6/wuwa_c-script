using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02000F4C RID: 3916
	[NetMessage(EMessageId.RhythmShipStartNotify)]
	public sealed class RhythmShipStartNotify : IMessage<RhythmShipStartNotify>, IMessage, IEquatable<RhythmShipStartNotify>, IDeepCloneable<RhythmShipStartNotify>, IBufferMessage
	{
		// Token: 0x06014F39 RID: 85817 RVA: 0x0030A380 File Offset: 0x00308580
		[NullableContext(1)]
		public static RhythmShipStartNotify Create()
		{
			return new RhythmShipStartNotify();
		}

		// Token: 0x170045B0 RID: 17840
		// (get) Token: 0x06014F3A RID: 85818 RVA: 0x0030A387 File Offset: 0x00308587
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170045B1 RID: 17841
		// (get) Token: 0x06014F3B RID: 85819 RVA: 0x0030A38A File Offset: 0x0030858A
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RhythmShipStartNotify.Descriptor;
			}
		}

		// Token: 0x06014F3C RID: 85820 RVA: 0x0030A391 File Offset: 0x00308591
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipStartNotify()
		{
		}

		// Token: 0x06014F3D RID: 85821 RVA: 0x0030A399 File Offset: 0x00308599
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipStartNotify(RhythmShipStartNotify other) : this()
		{
			this.subLevelId_ = other.subLevelId_;
			this.rhythmRoleId_ = other.rhythmRoleId_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06014F3E RID: 85822 RVA: 0x0030A3CA File Offset: 0x003085CA
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RhythmShipStartNotify Clone()
		{
			return new RhythmShipStartNotify(this);
		}

		// Token: 0x170045B2 RID: 17842
		// (get) Token: 0x06014F3F RID: 85823 RVA: 0x0030A3D2 File Offset: 0x003085D2
		// (set) Token: 0x06014F40 RID: 85824 RVA: 0x0030A3DA File Offset: 0x003085DA
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

		// Token: 0x170045B3 RID: 17843
		// (get) Token: 0x06014F41 RID: 85825 RVA: 0x0030A3E3 File Offset: 0x003085E3
		// (set) Token: 0x06014F42 RID: 85826 RVA: 0x0030A3EB File Offset: 0x003085EB
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

		// Token: 0x06014F43 RID: 85827 RVA: 0x0030A3F4 File Offset: 0x003085F4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RhythmShipStartNotify);
		}

		// Token: 0x06014F44 RID: 85828 RVA: 0x0030A402 File Offset: 0x00308602
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RhythmShipStartNotify other)
		{
			return other != null && (other == this || (this.SubLevelId == other.SubLevelId && this.RhythmRoleId == other.RhythmRoleId && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06014F45 RID: 85829 RVA: 0x0030A440 File Offset: 0x00308640
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

		// Token: 0x06014F46 RID: 85830 RVA: 0x0030A498 File Offset: 0x00308698
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06014F47 RID: 85831 RVA: 0x0030A4A5 File Offset: 0x003086A5
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06014F48 RID: 85832 RVA: 0x0030A4B0 File Offset: 0x003086B0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.SubLevelId != 0)
			{
				output.WriteRawTag(32);
				output.WriteInt32(this.SubLevelId);
			}
			if (this.RhythmRoleId != 0)
			{
				output.WriteRawTag(56);
				output.WriteInt32(this.RhythmRoleId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06014F49 RID: 85833 RVA: 0x0030A50C File Offset: 0x0030870C
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

		// Token: 0x06014F4A RID: 85834 RVA: 0x0030A564 File Offset: 0x00308764
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

		// Token: 0x06014F4B RID: 85835 RVA: 0x0030A5B4 File Offset: 0x003087B4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06014F4C RID: 85836 RVA: 0x0030A5C0 File Offset: 0x003087C0
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
				if (num != 32U)
				{
					if (num != 56U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.RhythmRoleId = input.ReadInt32();
					}
				}
				else
				{
					this.SubLevelId = input.ReadInt32();
				}
			}
		}

		// Token: 0x04007E54 RID: 32340
		private UnknownFieldSet _unknownFields;

		// Token: 0x04007E55 RID: 32341
		public const int SubLevelIdFieldNumber = 4;

		// Token: 0x04007E56 RID: 32342
		private int subLevelId_;

		// Token: 0x04007E57 RID: 32343
		public const int RhythmRoleIdFieldNumber = 7;

		// Token: 0x04007E58 RID: 32344
		private int rhythmRoleId_;
	}
}
