using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace Aki.Protocol
{
	// Token: 0x02001263 RID: 4707
	[NetMessage(EMessageId.SimpleCombatEntitySubTypeChangeNotify)]
	public sealed class SimpleCombatEntitySubTypeChangeNotify : IMessage<SimpleCombatEntitySubTypeChangeNotify>, IMessage, IEquatable<SimpleCombatEntitySubTypeChangeNotify>, IDeepCloneable<SimpleCombatEntitySubTypeChangeNotify>, IBufferMessage
	{
		// Token: 0x0601921D RID: 102941 RVA: 0x003AA935 File Offset: 0x003A8B35
		[NullableContext(1)]
		public static SimpleCombatEntitySubTypeChangeNotify Create()
		{
			return new SimpleCombatEntitySubTypeChangeNotify();
		}

		// Token: 0x170054F7 RID: 21751
		// (get) Token: 0x0601921E RID: 102942 RVA: 0x003AA93C File Offset: 0x003A8B3C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public static MessageDescriptor Descriptor
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170054F8 RID: 21752
		// (get) Token: 0x0601921F RID: 102943 RVA: 0x003AA93F File Offset: 0x003A8B3F
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		MessageDescriptor IMessage.Descriptor
		{
			get
			{
				return SimpleCombatEntitySubTypeChangeNotify.Descriptor;
			}
		}

		// Token: 0x06019220 RID: 102944 RVA: 0x003AA946 File Offset: 0x003A8B46
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySubTypeChangeNotify()
		{
		}

		// Token: 0x06019221 RID: 102945 RVA: 0x003AA950 File Offset: 0x003A8B50
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySubTypeChangeNotify(SimpleCombatEntitySubTypeChangeNotify other) : this()
		{
			this.entityId_ = other.entityId_;
			this.newComponentData_ = ((other.newComponentData_ != null) ? other.newComponentData_.Clone() : null);
			this._unknownFields = UnknownFieldSet.Clone(other._unknownFields);
		}

		// Token: 0x06019222 RID: 102946 RVA: 0x003AA99C File Offset: 0x003A8B9C
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatEntitySubTypeChangeNotify Clone()
		{
			return new SimpleCombatEntitySubTypeChangeNotify(this);
		}

		// Token: 0x170054F9 RID: 21753
		// (get) Token: 0x06019223 RID: 102947 RVA: 0x003AA9A4 File Offset: 0x003A8BA4
		// (set) Token: 0x06019224 RID: 102948 RVA: 0x003AA9AC File Offset: 0x003A8BAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public long EntityId
		{
			get
			{
				return this.entityId_;
			}
			set
			{
				this.entityId_ = value;
			}
		}

		// Token: 0x170054FA RID: 21754
		// (get) Token: 0x06019225 RID: 102949 RVA: 0x003AA9B5 File Offset: 0x003A8BB5
		// (set) Token: 0x06019226 RID: 102950 RVA: 0x003AA9BD File Offset: 0x003A8BBD
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public SimpleCombatComponentPb NewComponentData
		{
			get
			{
				return this.newComponentData_;
			}
			set
			{
				this.newComponentData_ = value;
			}
		}

		// Token: 0x06019227 RID: 102951 RVA: 0x003AA9C6 File Offset: 0x003A8BC6
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override bool Equals(object other)
		{
			return this.Equals(other as SimpleCombatEntitySubTypeChangeNotify);
		}

		// Token: 0x06019228 RID: 102952 RVA: 0x003AA9D4 File Offset: 0x003A8BD4
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public bool Equals(SimpleCombatEntitySubTypeChangeNotify other)
		{
			return other != null && (other == this || (this.EntityId == other.EntityId && object.Equals(this.NewComponentData, other.NewComponentData) && object.Equals(this._unknownFields, other._unknownFields)));
		}

		// Token: 0x06019229 RID: 102953 RVA: 0x003AAA24 File Offset: 0x003A8C24
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override int GetHashCode()
		{
			int num = 1;
			if (this.EntityId != 0L)
			{
				num ^= this.EntityId.GetHashCode();
			}
			if (this.newComponentData_ != null)
			{
				num ^= this.NewComponentData.GetHashCode();
			}
			if (this._unknownFields != null)
			{
				num ^= this._unknownFields.GetHashCode();
			}
			return num;
		}

		// Token: 0x0601922A RID: 102954 RVA: 0x003AAA79 File Offset: 0x003A8C79
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public override string ToString()
		{
			return base.GetType().Name;
		}

		// Token: 0x0601922B RID: 102955 RVA: 0x003AAA86 File Offset: 0x003A8C86
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void WriteTo(CodedOutputStream output)
		{
			output.WriteRawMessage(this);
		}

		// Token: 0x0601922C RID: 102956 RVA: 0x003AAA90 File Offset: 0x003A8C90
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		void IBufferMessage.InternalWriteTo(ref WriteContext output)
		{
			if (this.newComponentData_ != null)
			{
				output.WriteRawTag(26);
				output.WriteMessage(this.NewComponentData);
			}
			if (this.EntityId != 0L)
			{
				output.WriteRawTag(120);
				output.WriteInt64(this.EntityId);
			}
			if (this._unknownFields != null)
			{
				this._unknownFields.WriteTo(ref output);
			}
		}

		// Token: 0x0601922D RID: 102957 RVA: 0x003AAAEC File Offset: 0x003A8CEC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public int CalculateSize()
		{
			int num = 0;
			if (this.EntityId != 0L)
			{
				num += 1 + CodedOutputStream.ComputeInt64Size(this.EntityId);
			}
			if (this.newComponentData_ != null)
			{
				num += 1 + CodedOutputStream.ComputeMessageSize(this.NewComponentData);
			}
			if (this._unknownFields != null)
			{
				num += this._unknownFields.CalculateSize();
			}
			return num;
		}

		// Token: 0x0601922E RID: 102958 RVA: 0x003AAB44 File Offset: 0x003A8D44
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(SimpleCombatEntitySubTypeChangeNotify other)
		{
			if (other == null)
			{
				return;
			}
			if (other.EntityId != 0L)
			{
				this.EntityId = other.EntityId;
			}
			if (other.newComponentData_ != null)
			{
				if (this.newComponentData_ == null)
				{
					this.NewComponentData = new SimpleCombatComponentPb();
				}
				this.NewComponentData.MergeFrom(other.NewComponentData);
			}
			this._unknownFields = UnknownFieldSet.MergeFrom(this._unknownFields, other._unknownFields);
		}

		// Token: 0x0601922F RID: 102959 RVA: 0x003AABAC File Offset: 0x003A8DAC
		[DebuggerNonUserCode]
		[GeneratedCode("protoc", null)]
		public void MergeFrom(CodedInputStream input)
		{
			input.ReadRawMessage(this);
		}

		// Token: 0x06019230 RID: 102960 RVA: 0x003AABB8 File Offset: 0x003A8DB8
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
				if (num != 26U)
				{
					if (num != 120U)
					{
						this._unknownFields = UnknownFieldSet.MergeFieldFrom(this._unknownFields, ref input);
					}
					else
					{
						this.EntityId = input.ReadInt64();
					}
				}
				else
				{
					if (this.newComponentData_ == null)
					{
						this.NewComponentData = new SimpleCombatComponentPb();
					}
					input.ReadMessage(this.NewComponentData);
				}
			}
		}

		// Token: 0x040094D9 RID: 38105
		private UnknownFieldSet _unknownFields;

		// Token: 0x040094DA RID: 38106
		public const int EntityIdFieldNumber = 15;

		// Token: 0x040094DB RID: 38107
		private long entityId_;

		// Token: 0x040094DC RID: 38108
		public const int NewComponentDataFieldNumber = 3;

		// Token: 0x040094DD RID: 38109
		private SimpleCombatComponentPb newComponentData_;
	}
}
