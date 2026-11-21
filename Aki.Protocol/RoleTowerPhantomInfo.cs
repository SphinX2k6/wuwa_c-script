using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x020010D3 RID: 4307
	public sealed class RoleTowerPhantomInfo : IMessage<RoleTowerPhantomInfo>, IMessage, IEquatable<RoleTowerPhantomInfo>, IDeepCloneable<RoleTowerPhantomInfo>, IBufferMessage
	{
		// Token: 0x06017055 RID: 94293 RVA: 0x0035910D File Offset: 0x0035730D
		[NullableContext(1)]
		public static RoleTowerPhantomInfo Create()
		{
			return new RoleTowerPhantomInfo();
		}

		// Token: 0x17004D3D RID: 19773
		// (get) Token: 0x06017056 RID: 94294 RVA: 0x00359114 File Offset: 0x00357314
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17004D3E RID: 19774
		// (get) Token: 0x06017057 RID: 94295 RVA: 0x00359117 File Offset: 0x00357317
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return RoleTowerPhantomInfo.Descriptor;
			}
		}

		// Token: 0x06017058 RID: 94296 RVA: 0x0035911E File Offset: 0x0035731E
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomInfo()
		{
		}

		// Token: 0x06017059 RID: 94297 RVA: 0x00359126 File Offset: 0x00357326
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomInfo(RoleTowerPhantomInfo other) : this()
		{
			this.level_ = other.level_;
			this.curExp_ = other.curExp_;
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x0601705A RID: 94298 RVA: 0x00359157 File Offset: 0x00357357
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public RoleTowerPhantomInfo Clone()
		{
			return new RoleTowerPhantomInfo(this);
		}

		// Token: 0x17004D3F RID: 19775
		// (get) Token: 0x0601705B RID: 94299 RVA: 0x0035915F File Offset: 0x0035735F
		// (set) Token: 0x0601705C RID: 94300 RVA: 0x00359167 File Offset: 0x00357367
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int Level
		{
			get
			{
				return this.level_;
			}
			set
			{
				this.level_ = value;
			}
		}

		// Token: 0x17004D40 RID: 19776
		// (get) Token: 0x0601705D RID: 94301 RVA: 0x00359170 File Offset: 0x00357370
		// (set) Token: 0x0601705E RID: 94302 RVA: 0x00359178 File Offset: 0x00357378
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CurExp
		{
			get
			{
				return this.curExp_;
			}
			set
			{
				this.curExp_ = value;
			}
		}

		// Token: 0x0601705F RID: 94303 RVA: 0x00359181 File Offset: 0x00357381
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as RoleTowerPhantomInfo);
		}

		// Token: 0x06017060 RID: 94304 RVA: 0x0035918F File Offset: 0x0035738F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(RoleTowerPhantomInfo other)
		{
			return other != null && (other == this || (this.Level == other.Level && this.CurExp == other.CurExp && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06017061 RID: 94305 RVA: 0x003591D0 File Offset: 0x003573D0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.Level != 0)
			{
				num ^= this.Level.GetHashCode();
			}
			if (this.CurExp != 0)
			{
				num ^= this.CurExp.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x06017062 RID: 94306 RVA: 0x00359228 File Offset: 0x00357428
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x06017063 RID: 94307 RVA: 0x00359235 File Offset: 0x00357435
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x06017064 RID: 94308 RVA: 0x00359240 File Offset: 0x00357440
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.Level != 0)
			{
				output.WriteRawTag(8);
				output.WriteInt32(this.Level);
			}
			if (this.CurExp != 0)
			{
				output.WriteRawTag(16);
				output.WriteInt32(this.CurExp);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x06017065 RID: 94309 RVA: 0x00359298 File Offset: 0x00357498
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.Level != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.Level);
			}
			if (this.CurExp != 0)
			{
				num += 1 + CodedOutputStream.ComputeInt32Size(this.CurExp);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x06017066 RID: 94310 RVA: 0x003592F0 File Offset: 0x003574F0
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(RoleTowerPhantomInfo other)
		{
			if (other == null)
			{
				return;
			}
			if (other.Level != 0)
			{
				this.Level = other.Level;
			}
			if (other.CurExp != 0)
			{
				this.CurExp = other.CurExp;
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x06017067 RID: 94311 RVA: 0x00359340 File Offset: 0x00357540
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06017068 RID: 94312 RVA: 0x0035934C File Offset: 0x0035754C
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
						this.CurExp = input.ReadInt32();
					}
				}
				else
				{
					this.Level = input.ReadInt32();
				}
			}
		}

		// Token: 0x040089C4 RID: 35268
		private UnknownFieldSet _unknownFields;

		// Token: 0x040089C5 RID: 35269
		public const int LevelFieldNumber = 1;

		// Token: 0x040089C6 RID: 35270
		private int level_;

		// Token: 0x040089C7 RID: 35271
		public const int CurExpFieldNumber = 2;

		// Token: 0x040089C8 RID: 35272
		private int curExp_;
	}
}
